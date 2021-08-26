using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using Newtonsoft.Json;
using System.IO;


namespace Vector_Workshop
{
    public partial class _2d : Form
    {
        public int crypt_pass = 7;
        public User_Data user_data = new User_Data();
        private int editings = 0;
        float one_line_rate = 25;
        public Color data_color;
        public bool pointer = false;
        public Vector2[] pointers = new Vector2[] {new Vector2(777,777), new Vector2(777,777) };
        public System.Windows.Forms.Timer aTimer = new System.Windows.Forms.Timer();
        private Color[] effect = { Color.MediumPurple, Color.BlueViolet, Color.LightGreen, Color.Cyan, Color.LightSkyBlue, Color.IndianRed};
        private int j = 0;

        #region event handlers
        private void form_loaded()//when the new form loaded
        {
            System.Threading.Thread.Sleep(100);
            main_write_vector_lines();

            
        }

        private void form_closed(object sender, FormClosingEventArgs e)//when the current form is closed
        {
            if (editings > 0)
            {
                DialogResult exit_sure = MessageBox.Show("Are you sure to exit all your process will gone/Çıkmaktan emin misiniz? Tüm çalışmalarınız silinecektir", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (exit_sure == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }



        }
        public _2d()//main
        {
            InitializeComponent();
            FormClosing += form_closed;
            aTimer.Tick += Update;
            aTimer.Interval = 100; //milisecunde
            aTimer.Enabled = true;
            System.Threading.Thread thread = new Thread(new ThreadStart(form_loaded));
            thread.Start();
        }
        private void Update(object sender, EventArgs e)
        {
            if(TEST_DEBUG_BUTTON.Visible)
            {
                if(j < effect.Length)
                {
                    TEST_DEBUG_BUTTON.BackColor = effect[j];
                    j++;
                }
                else if(j == effect.Length)
                    j = 0;
            }
        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && is_pencil_draw.Checked)
            {
                Vector2 mouse_cursor_pos = new Vector2(((System.Windows.Forms.Cursor.Position.X - this.Location.X) - 7), (System.Windows.Forms.Cursor.Position.Y - this.Location.Y) - 30);

                if (mouse_cursor_pos.x <= 550 &&
                mouse_cursor_pos.x >= 50 &&
                mouse_cursor_pos.y <= 530 &&
                mouse_cursor_pos.y >= 30)
                {
                    Graphics g = this.CreateGraphics();
                    try
                    {
                        g.DrawLine(new Pen(Color.FromName(get_pen_color.Text.Remove(get_pen_color.Text.IndexOf('/'))), float.Parse(pencil_width.Text)), mouse_cursor_pos.x - 1.5f, mouse_cursor_pos.y - 0.5f, mouse_cursor_pos.x + 1.5f, mouse_cursor_pos.y + 0.5f);
                        user_data.user_marks.Add(new User_Drawn_Marks(mouse_cursor_pos, get_pen_color.Text, float.Parse(pencil_width.Text)));
                    }
                    catch 
                    { 
                        MessageBox.Show("Your pencil width must be a number/Kalem kalınlığı sayı olmak zorundadır", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                }
            }
        }
        private void draw_marks_from_database()
        {
            for(int j = 0; j < user_data.user_marks.Count; j++)
            {
                Vector2 mouse_cursor_pos = user_data.user_marks[j].pos;
                get_pen_color.Text = user_data.user_marks[j].mark_color;
                Graphics g = this.CreateGraphics();
                g.DrawLine(new Pen(Color.FromName(get_pen_color.Text.Remove(get_pen_color.Text.IndexOf('/'))), 3.5f), mouse_cursor_pos.x - 1.5f, mouse_cursor_pos.y - 0.5f, mouse_cursor_pos.x + 1.5f, mouse_cursor_pos.y + 0.5f);

            }
        }
        private void mouse_down(object sender, MouseEventArgs e)
        {
            Vector2 fixed_positions = new Vector2(777, 777);
            Vector2 mouse_cursor_pos = new Vector2(((System.Windows.Forms.Cursor.Position.X - this.Location.X) - 58), (System.Windows.Forms.Cursor.Position.Y - this.Location.Y) - 60);


            if (mouse_cursor_pos.x <= 500 &&
                mouse_cursor_pos.x >= 0 &&
                mouse_cursor_pos.y <= 500 &&
                mouse_cursor_pos.y >= 0)
            {

                if (!is_pencil_draw.Checked)
                {
                    if (pointers[0].x == 777)
                    {
                        if (set_pos_corner.Checked)
                        {
                            #region getting the positions
                            for (int j = 0; j < 525; j += 25)
                            {
                                //dont care pos is greater than 0 or less than 0 for now
                                if (mouse_cursor_pos.x <= j - 10 || mouse_cursor_pos.x <= j + 10)
                                {
                                    fixed_positions.x = j;
                                    break;
                                }
                            }
                            for (int j = 0; j < 550; j += 25)
                            {
                                //dont care pos is greater than 0 or less than 0 for now
                                if (mouse_cursor_pos.y <= j - 10 || mouse_cursor_pos.y <= j + 10)
                                {
                                    fixed_positions.y = j;
                                    break;
                                }
                            }


                            fixed_positions = vector_range<Vector2>(fixed_positions);
                            
                            #endregion

                        }
                        else if (!set_pos_corner.Checked)
                        {
                            
                            fixed_positions = vector_range<Vector2>(mouse_cursor_pos);

                        }

                        pointers[0] = fixed_positions;
                        startposx.Text = fixed_positions.x.ToString();
                        startposy.Text = fixed_positions.y.ToString();
                    }
                    else if (pointers[1].x == 777)
                    {
                        if (set_pos_corner.Checked)
                        {
                            #region getting the positions
                            for (int j = 0; j < 525; j += 25)
                            {
                                //dont care pos is greater than 0 or less than 0 for now
                                if (mouse_cursor_pos.x <= j - 10 || mouse_cursor_pos.x <= j + 10)
                                {
                                    fixed_positions.x = j;
                                    break;
                                }
                            }
                            for (int j = 0; j < 550; j += 25)
                            {
                                //dont care pos is greater than 0 or less than 0 for now
                                if (mouse_cursor_pos.y <= j - 10 || mouse_cursor_pos.y <= j + 10)
                                {
                                    fixed_positions.y = j;
                                    break;
                                }
                            }


                            fixed_positions = vector_range<Vector2>(fixed_positions);

                            #endregion
                        }
                        else if (!set_pos_corner.Checked)
                        {
                            fixed_positions = vector_range<Vector2>(mouse_cursor_pos);

                        }
                        pointers[1] = fixed_positions;

                        endposx.Text = fixed_positions.x.ToString();
                        endposy.Text = fixed_positions.y.ToString();
                        //drawing it 
                        pointers[0] = new Vector2(777, 777);
                        pointers[1] = new Vector2(777, 777);

                        user_draw_line_button("false");
                    }
                }
                else if(is_pencil_draw.Checked)
                { }//dont need for now
            }

        }

        #endregion

        #region functions
        public static void AddEncryption(string FileName)
        {

            File.Encrypt(FileName);
        }

        // Decrypt a file.
        public static void RemoveEncryption(string FileName)
        {
            File.Decrypt(FileName);
        }
        public static float round_float(float inserted_value)
        {
            float result = Convert.ToSingle(Math.Round(Convert.ToDecimal(inserted_value)));
            return result;

        }
        private void TEST_DEBUG_BUTTON_Click(object sender, EventArgs e)
        {

        }

        private T vector_range<T>(dynamic user_value)
        {

            if (user_value.GetType() == typeof(Vector2))
            {
                Vector2 result = user_value;
                //x6
                if (result.x == 250)
                {
                    result.x = 0;
                }
                else if (result.x < 250)// x:275 to result:25
                {
                    result.x = -1 * (250 - result.x);
                    result.x = round_float(result.x * (float.Parse(one_line.Text) / 25));
                }
                else if(result.x > 250)
                {
                    result.x = -1 * (250 - result.x);
                    result.x = round_float(result.x * (float.Parse(one_line.Text) / 25));
                }
                //y
                if(result.y == 250)
                {
                    result.y = 0;
                }
                else if(result.y < 250)
                {
                    result.y = (250 - result.y);
                    result.y = round_float(result.y * (float.Parse(one_line.Text) / 25));
                }
                else if(result.y > 250)
                {
                    result.y = (250 - result.y);
                    result.y = round_float(result.y * (float.Parse(one_line.Text) / 25));
                }
                dynamic result_return = result;
                return result_return;
            }
            throw new System.IndexOutOfRangeException("undefined dynamic variable");
           
        }
        /// <summary>
        /// mode:0 default, mode:1 for main lines, mode:2 for over orijin, mode:3 orijin max ways
        /// </summary>
        private void draw_line(Vector2 start_pos, Vector2 end_pos, float width = 5, int modes = 0, int line_int = 25)
        {
            Graphics g = this.CreateGraphics();
            Color current_color = Color.Gray;

            if (line_int != 25)
            {
                try
                {
                    float change_rate = float.Parse(one_line.Text) / 25;

                    start_pos.x = start_pos.x / change_rate;
                    start_pos.y = start_pos.y / change_rate;
                    end_pos.x = end_pos.x / change_rate;
                    end_pos.y = end_pos.y / change_rate;
                }
                catch
                {
                    MessageBox.Show("Please Check The 1 Line Length Setting/Lütfen 1 Çizginin Uzunluğu Ayarını Gözden Geçirin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (modes == 1)
            {
                current_color = Color.Gray;




            }
            else if (modes == 2)//user draw
            {
            
                if (!String.IsNullOrEmpty(vectorcolor.Text))
                    current_color = Color.FromName(vectorcolor.Text.Remove(vectorcolor.Text.IndexOf('/')));

                else
                {
                    MessageBox.Show("Please choose a color for vector/Lütfen vektör için bir renk seç", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                start_pos.y = -start_pos.y;
                end_pos.y = -end_pos.y;

                start_pos.x += 250;
                start_pos.y += 250;
                end_pos.x += 250;
                end_pos.y += 250;

                string start_def = null;
                string end_def = null;
                if (isdefstart.Checked)
                {
                    Vector2 round = vector_range<Vector2>(new Vector2(start_pos.x, start_pos.y)) ;
                    g.DrawString(String.Format(startdefine.Text, round.x, round.y), new Font("Arial", 10), new SolidBrush(Color.Aqua), start_pos.x - 0.4f, start_pos.y - 0.4f);
                    start_def = startdefine.Text;
                }
                if (isdefend.Checked)
                {
                    Vector2 round = vector_range<Vector2>(new Vector2(end_pos.x, end_pos.y));
                    g.DrawString(String.Format(enddefine.Text, round.x, round.y), new Font("Arial", 10), new SolidBrush(Color.Aqua), end_pos.x - 0.4f, end_pos.y - 0.4f);
                    end_def = enddefine.Text;
                }
                user_data.one_line_eq = one_line_rate;
                user_data.user_vectors.Add(new User_Drawn_Vectors(new Vector2(float.Parse(startposx.Text), float.Parse(startposy.Text)), new Vector2(float.Parse(endposx.Text), float.Parse(endposy.Text)), vectorcolor.Text, start_def, end_def));
                editings++;

            
            }
            else if (modes == 3)
            {

                start_pos.y = -start_pos.y;
                end_pos.y = -end_pos.y;

                start_pos.x += 250;
                start_pos.y += 250;
                end_pos.x += 250;
                end_pos.y += 250;



                current_color = Color.WhiteSmoke;
            }

            g.DrawLine(new Pen(current_color, width), start_pos.x + 50, start_pos.y + 30, end_pos.x + 50, end_pos.y + 30);

            //printing the poses

            draw_line_rate();

        }
        private void clear_all_lines()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            main_write_vector_lines();

        }

        private void draw_line_rate()
        {

            Graphics g = this.CreateGraphics();

            float i = 0;
            bool on_negative_form = false;
            float string_size_y = 10f;
            int string_size_x = 10;
            for (float j = +25; j <= 525; j += 25)
            {
                //y
                if (on_negative_form && i <= 21)
                    g.DrawString(($"-{(i * one_line_rate)}"), new Font("Arial", string_size_y), new SolidBrush(Color.White), 0, j - 1);
                else if (i == 10)
                {
                    i = 0;
                    on_negative_form = true;
                    g.DrawString(($"0"), new Font("Arial", string_size_y), new SolidBrush(Color.White), 0, j);
                }
                else if (i >= 0 && i <= 21 && !on_negative_form)

                    g.DrawString(($"{(one_line_rate * 10) - (i * one_line_rate)}"), new Font("Arial", string_size_y), new SolidBrush(Color.White), 0, j);

                //x

                if (on_negative_form && i <= 21)
                    g.DrawString(($"{(i * one_line_rate)}"), new Font("Arial", string_size_x), new SolidBrush(Color.White), j + 15, 535);
                else if (i == 10)
                {
                    i = 0;
                    on_negative_form = true;
                    g.DrawString(($"                     0"), new Font("Arial", string_size_x), new SolidBrush(Color.White), j + 15, 535);
                }
                else if (i >= 0 && i <= 21 && !on_negative_form)

                    g.DrawString(($"-{(one_line_rate * 10) - (i * one_line_rate)}"), new Font("Arial", string_size_x), new SolidBrush(Color.White), j + 15, 535);


                i++;
            }

        }

        private void clear_string()
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(new Pen(Color.Black, 54), 10, -10, 10, 1200);
            g.DrawLine(new Pen(Color.Black, 54), 0, 560, 570, 560);
        }
        /// <summary>
        /// y max: 500
        /// x max: 500
        /// middle: 250,250
        /// </summary>
        public void main_write_vector_lines()
        {
            for (int j = 0; j < 525; j += 25)
            {
                draw_line(new Vector2(0, j), new Vector2(500, j), 0.1f, 1);
                draw_line(new Vector2(j, 0), new Vector2(j, 500), 0.1f, 1);
            }
            draw_line(new Vector2(0, 250), new Vector2(0, -250), 2, 3);
            draw_line(new Vector2(250, 0), new Vector2(-250, 0), 2, 3);
        }
        private string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        private string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        #endregion

        #region buttons
        private void save_data_button_Click(object sender, EventArgs e)
        {
            string data_string = Base64Encode( JsonConvert.SerializeObject(user_data));
            SaveFileDialog ask_path = new SaveFileDialog();
            ask_path.FileName = "vectorwork.vw";
            
            ask_path.Filter = "Vector Workshop files |*.vw";
            if (ask_path.ShowDialog() == DialogResult.OK)
            {
               
                File.Delete(ask_path.FileName);
                File.WriteAllText(ask_path.FileName, data_string);
            }
            editings = 0;
        }

        private void cleaner_but_Click(object sender = null, EventArgs e = null)
        {
            if(sender != null && sender.ToString() != "dontclear")
            {
                user_data.user_vectors.Clear();
                user_data.user_marks.Clear();
            }
                

            pointers[0] = new Vector2(777, 777);
            pointers[1] = new Vector2(777, 777);

            clear_string();
            clear_all_lines();
            editings = 0;
        }

        private void bug_button_Click(object sender, EventArgs e)//refresh button
        {
            if(user_data.user_vectors.Count > 0 || user_data.user_marks.Count > 0)
            {
                System.Threading.Thread.Sleep(10);
                main_write_vector_lines();
                draw_marks_from_database();
                
            }
            else if(user_data.user_vectors.Count == 0)
            {
                cleaner_but_Click();
            }

        }

        private void user_draw_line_button(object sender = null, EventArgs e = null)
        {


            //!(Char.IsNumber(startposx.Text, 0) && Char.IsNumber(startposy.Text, 0) && Char.IsNumber(endposx.Text, 0) && Char.IsNumber(endposy.Text, 0))
            if (false)//disabled for now
            {
                MessageBox.Show("please insert your vector postitions as integer/lütfen vektörünüzün pozisyonlarını tam sayı olarak doldurunuz");
            }
            else
            {
                try
                {

                    if (over_origin.Checked)
                    {
                        one_line_rate = float.Parse(one_line.Text);//default 25
                        if(sender.ToString() != "true")
                            clear_string();
                        draw_line(new Vector2(int.Parse(startposx.Text), int.Parse(startposy.Text)), new Vector2(int.Parse(endposx.Text), int.Parse(endposy.Text)), 2, 2, 50);
                    }
                    else if (!over_origin.Checked)//not available disabled by dev
                    {
                        one_line_rate = float.Parse(one_line.Text);//default 25
                        clear_string();
                        draw_line(new Vector2(int.Parse(startposx.Text), int.Parse(startposy.Text)), new Vector2(int.Parse(endposx.Text), int.Parse(endposy.Text)), 2, 0, 50);
                    }
                }
                catch
                {
                    MessageBox.Show("Please insert your vector postitions as integer/Lütfen vektörünüzün pozisyonlarını tam sayı olarak doldurunuz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void open_data_button_Click(object sender, EventArgs e)
        {
            string file_path;
            OpenFileDialog json_data = new OpenFileDialog();
            json_data.FileName = "vectorwork.vw";
            json_data.Filter = "Vector Workshop files |*.vw";
            if (json_data.ShowDialog() == DialogResult.OK)
            {
                for (int j = 0; j < user_data.user_vectors.Count; j++)
                    user_data.user_vectors[j] = null;
                file_path = json_data.FileName;
                StreamReader read_json = new StreamReader(file_path);

                user_data = JsonConvert.DeserializeObject<User_Data>(Base64Decode( read_json.ReadToEnd()));
                one_line.Text = user_data.one_line_eq.ToString();
                read_json.Close();
                //value reseting

                cleaner_but_Click("dontclear");
                if (user_data.user_vectors.Count != 0)
                    draw_vectors_from_data();
                draw_marks_from_database();
                //vector_board.Text = user_data.user_vectors[0].start__pos.x.ToString();


            }
            editings = 0;
        }
        private void draw_vectors_from_data()
        {
            clear_string();
            int counter = user_data.user_vectors.Count;
            for (int j = 0; j < counter; j++)
            {
                vectorcolor.Text = user_data.user_vectors[j].vec_color;
                startposx.Text = user_data.user_vectors[j].start__pos.x.ToString();
                startposy.Text = user_data.user_vectors[j].start__pos.y.ToString();
                endposx.Text = user_data.user_vectors[j].end__pos.x.ToString();
                endposy.Text = user_data.user_vectors[j].end__pos.y.ToString();
               
                //draw_line(new Vector2(int.Parse(startposx.Text), int.Parse(startposy.Text)), new Vector2(int.Parse(endposx.Text), int.Parse(endposy.Text)), 2, 4,12312);
                user_draw_line_button("true");
            }
        }





        #endregion

    }

    #region Database
    public class User_Data
    {
        public float one_line_eq;
        public List<User_Drawn_Vectors> user_vectors = new List<User_Drawn_Vectors>();
        public List<User_Drawn_Marks> user_marks = new List<User_Drawn_Marks>();

    }
    public class User_Drawn_Vectors
    {
        public string vec_color;
        public Vector2 start__pos;
        public Vector2 end__pos;
        public string start_def;
        public string end_def;
        public User_Drawn_Vectors(Vector2 start__pos, Vector2 end__pos, string vec_color, string start_def = null, string end_def = null)
        {

            this.start__pos = start__pos;
            this.end__pos = end__pos;
            this.vec_color = vec_color;
            if (start_def != null)
            {
                this.start_def = start_def;
            }
            if (start_def != null)
            {
                this.end_def = end_def;
            }

        }


    }
    public class User_Drawn_Marks
    {
        public string mark_color;
        public float mark_width;
        public Vector2 pos;
        public User_Drawn_Marks(Vector2 pos, string mark_color, float mark_width)
        {
            this.mark_width = mark_width;
            this.mark_color = mark_color;
            this.pos = pos;
        }
    }
    #endregion

    #region Vector2
    public class Vector2
    {
        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float x;
        public float y;

    }
    #endregion
}
