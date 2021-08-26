namespace Vector_Workshop
{
    partial class _2d
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_2d));
            this.button1 = new System.Windows.Forms.Button();
            this.startpos = new System.Windows.Forms.Label();
            this.endpos = new System.Windows.Forms.Label();
            this.endposx = new System.Windows.Forms.TextBox();
            this.startposx = new System.Windows.Forms.TextBox();
            this.startposy = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cleaner_but = new System.Windows.Forms.Button();
            this.bug_button = new System.Windows.Forms.Button();
            this.one_line = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.defstart = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.isdefend = new System.Windows.Forms.CheckBox();
            this.isdefstart = new System.Windows.Forms.CheckBox();
            this.enddefine = new System.Windows.Forms.TextBox();
            this.startdefine = new System.Windows.Forms.TextBox();
            this.vectorcolor = new System.Windows.Forms.ComboBox();
            this.endposy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.save_data_button = new System.Windows.Forms.Button();
            this.open_data_button = new System.Windows.Forms.Button();
            this.set_pos_corner = new System.Windows.Forms.CheckBox();
            this.over_origin = new System.Windows.Forms.CheckBox();
            this.TEST_DEBUG_BUTTON = new System.Windows.Forms.Button();
            this.pencil_draw_img = new System.Windows.Forms.PictureBox();
            this.is_pencil_draw = new System.Windows.Forms.CheckBox();
            this.pen_label = new System.Windows.Forms.Label();
            this.get_pen_color = new System.Windows.Forms.ComboBox();
            this.pencil_width = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pencil_draw_img)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw Vector/Vektör Ciz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.user_draw_line_button);
            // 
            // startpos
            // 
            this.startpos.AutoSize = true;
            this.startpos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.startpos.Location = new System.Drawing.Point(571, 7);
            this.startpos.Name = "startpos";
            this.startpos.Size = new System.Drawing.Size(171, 13);
            this.startpos.TabIndex = 6;
            this.startpos.Text = "Start Position/Başalngıç Pozisyonu";
            // 
            // endpos
            // 
            this.endpos.AutoSize = true;
            this.endpos.ForeColor = System.Drawing.Color.DarkRed;
            this.endpos.Location = new System.Drawing.Point(600, 83);
            this.endpos.Name = "endpos";
            this.endpos.Size = new System.Drawing.Size(141, 13);
            this.endpos.TabIndex = 7;
            this.endpos.Text = "End Position/Bitiş Pozisyonu";
            // 
            // endposx
            // 
            this.endposx.Location = new System.Drawing.Point(764, 81);
            this.endposx.Multiline = true;
            this.endposx.Name = "endposx";
            this.endposx.Size = new System.Drawing.Size(23, 19);
            this.endposx.TabIndex = 8;
            // 
            // startposx
            // 
            this.startposx.Location = new System.Drawing.Point(765, 4);
            this.startposx.Name = "startposx";
            this.startposx.Size = new System.Drawing.Size(23, 20);
            this.startposx.TabIndex = 10;
            // 
            // startposy
            // 
            this.startposy.Location = new System.Drawing.Point(807, 4);
            this.startposy.Name = "startposy";
            this.startposy.Size = new System.Drawing.Size(24, 20);
            this.startposy.TabIndex = 11;
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.ForeColor = System.Drawing.SystemColors.Highlight;
            this.x.Location = new System.Drawing.Point(747, 83);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(15, 13);
            this.x.TabIndex = 12;
            this.x.Text = "x:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(790, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(748, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "x:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(790, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "y:";
            // 
            // cleaner_but
            // 
            this.cleaner_but.Location = new System.Drawing.Point(646, 354);
            this.cleaner_but.Name = "cleaner_but";
            this.cleaner_but.Size = new System.Drawing.Size(181, 23);
            this.cleaner_but.TabIndex = 16;
            this.cleaner_but.Text = "Clear All Vectors/Tüm Vektörleri Sil";
            this.cleaner_but.UseVisualStyleBackColor = true;
            this.cleaner_but.Click += new System.EventHandler(this.cleaner_but_Click);
            // 
            // bug_button
            // 
            this.bug_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bug_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bug_button.Location = new System.Drawing.Point(652, 505);
            this.bug_button.Name = "bug_button";
            this.bug_button.Size = new System.Drawing.Size(177, 54);
            this.bug_button.TabIndex = 19;
            this.bug_button.Text = "Somethings Gone Wrong? Press Here/Birşeyler Ters Mi Gitti? Buraya Tıkla";
            this.bug_button.UseVisualStyleBackColor = true;
            this.bug_button.Click += new System.EventHandler(this.bug_button_Click);
            // 
            // one_line
            // 
            this.one_line.Location = new System.Drawing.Point(778, 183);
            this.one_line.Name = "one_line";
            this.one_line.Size = new System.Drawing.Size(51, 20);
            this.one_line.TabIndex = 21;
            this.one_line.Text = "25";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(556, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "1 Line Length Equals to:/1 Çizginin Uzunluğu:";
            // 
            // defstart
            // 
            this.defstart.AutoSize = true;
            this.defstart.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.defstart.Location = new System.Drawing.Point(566, 30);
            this.defstart.Name = "defstart";
            this.defstart.Size = new System.Drawing.Size(176, 13);
            this.defstart.TabIndex = 23;
            this.defstart.Text = "Define The Vector/Vektörü Tanımla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(565, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Define The Vector/Vektörü Tanımla";
            // 
            // isdefend
            // 
            this.isdefend.AutoSize = true;
            this.isdefend.Location = new System.Drawing.Point(747, 107);
            this.isdefend.Name = "isdefend";
            this.isdefend.Size = new System.Drawing.Size(80, 17);
            this.isdefend.TabIndex = 25;
            this.isdefend.Text = "checkBox1";
            this.isdefend.UseVisualStyleBackColor = true;
            // 
            // isdefstart
            // 
            this.isdefstart.AutoSize = true;
            this.isdefstart.Location = new System.Drawing.Point(748, 29);
            this.isdefstart.Name = "isdefstart";
            this.isdefstart.Size = new System.Drawing.Size(80, 17);
            this.isdefstart.TabIndex = 26;
            this.isdefstart.Text = "checkBox1";
            this.isdefstart.UseVisualStyleBackColor = true;
            // 
            // enddefine
            // 
            this.enddefine.Location = new System.Drawing.Point(765, 107);
            this.enddefine.Multiline = true;
            this.enddefine.Name = "enddefine";
            this.enddefine.Size = new System.Drawing.Size(66, 19);
            this.enddefine.TabIndex = 27;
            this.enddefine.Text = "({0},{1})";
            // 
            // startdefine
            // 
            this.startdefine.Location = new System.Drawing.Point(765, 30);
            this.startdefine.Multiline = true;
            this.startdefine.Name = "startdefine";
            this.startdefine.Size = new System.Drawing.Size(66, 19);
            this.startdefine.TabIndex = 28;
            this.startdefine.Text = "({0},{1})";
            // 
            // vectorcolor
            // 
            this.vectorcolor.FormattingEnabled = true;
            this.vectorcolor.Items.AddRange(new object[] {
            "Red/Kırmızı",
            "Blue/Mavi",
            "Orange/Turuncu",
            "Yellow/Sarı",
            "Purple/Mor",
            "Silver/Gümüş",
            "Gray/Gri"});
            this.vectorcolor.Location = new System.Drawing.Point(734, 156);
            this.vectorcolor.Name = "vectorcolor";
            this.vectorcolor.Size = new System.Drawing.Size(95, 21);
            this.vectorcolor.TabIndex = 29;
            this.vectorcolor.Text = "Blue/Mavi";
            // 
            // endposy
            // 
            this.endposy.Location = new System.Drawing.Point(806, 82);
            this.endposy.Multiline = true;
            this.endposy.Name = "endposy";
            this.endposy.Size = new System.Drawing.Size(23, 19);
            this.endposy.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(580, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Vector Color/Vektör Rengi";
            // 
            // save_data_button
            // 
            this.save_data_button.Location = new System.Drawing.Point(650, 383);
            this.save_data_button.Name = "save_data_button";
            this.save_data_button.Size = new System.Drawing.Size(177, 50);
            this.save_data_button.TabIndex = 33;
            this.save_data_button.Text = "Save Current Work/Çalışmanı Kaydet";
            this.save_data_button.UseVisualStyleBackColor = true;
            this.save_data_button.Click += new System.EventHandler(this.save_data_button_Click);
            // 
            // open_data_button
            // 
            this.open_data_button.Location = new System.Drawing.Point(650, 439);
            this.open_data_button.Name = "open_data_button";
            this.open_data_button.Size = new System.Drawing.Size(177, 42);
            this.open_data_button.TabIndex = 34;
            this.open_data_button.Text = "Open Work/Çalışmanı Aç";
            this.open_data_button.UseVisualStyleBackColor = true;
            this.open_data_button.Click += new System.EventHandler(this.open_data_button_Click);
            // 
            // set_pos_corner
            // 
            this.set_pos_corner.AutoSize = true;
            this.set_pos_corner.Checked = true;
            this.set_pos_corner.CheckState = System.Windows.Forms.CheckState.Checked;
            this.set_pos_corner.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.set_pos_corner.Location = new System.Drawing.Point(677, 212);
            this.set_pos_corner.Name = "set_pos_corner";
            this.set_pos_corner.Size = new System.Drawing.Size(152, 17);
            this.set_pos_corner.TabIndex = 35;
            this.set_pos_corner.Text = "Corner lock/Köşe kitlemesi";
            this.set_pos_corner.UseVisualStyleBackColor = true;
            // 
            // over_origin
            // 
            this.over_origin.AutoSize = true;
            this.over_origin.Checked = true;
            this.over_origin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.over_origin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.over_origin.Location = new System.Drawing.Point(583, 306);
            this.over_origin.Name = "over_origin";
            this.over_origin.Size = new System.Drawing.Size(242, 17);
            this.over_origin.TabIndex = 20;
            this.over_origin.Text = "Transfrom It Over Origin/Orijin Üzerinden Çalış";
            this.over_origin.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.over_origin.UseVisualStyleBackColor = true;
            this.over_origin.Visible = false;
            // 
            // TEST_DEBUG_BUTTON
            // 
            this.TEST_DEBUG_BUTTON.Location = new System.Drawing.Point(583, 250);
            this.TEST_DEBUG_BUTTON.Name = "TEST_DEBUG_BUTTON";
            this.TEST_DEBUG_BUTTON.Size = new System.Drawing.Size(244, 50);
            this.TEST_DEBUG_BUTTON.TabIndex = 36;
            this.TEST_DEBUG_BUTTON.Text = "TEST";
            this.TEST_DEBUG_BUTTON.UseVisualStyleBackColor = true;
            this.TEST_DEBUG_BUTTON.Visible = false;
            this.TEST_DEBUG_BUTTON.Click += new System.EventHandler(this.TEST_DEBUG_BUTTON_Click);
            // 
            // pencil_draw_img
            // 
            this.pencil_draw_img.Image = ((System.Drawing.Image)(resources.GetObject("pencil_draw_img.Image")));
            this.pencil_draw_img.Location = new System.Drawing.Point(801, 245);
            this.pencil_draw_img.Name = "pencil_draw_img";
            this.pencil_draw_img.Size = new System.Drawing.Size(25, 25);
            this.pencil_draw_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pencil_draw_img.TabIndex = 37;
            this.pencil_draw_img.TabStop = false;
            // 
            // is_pencil_draw
            // 
            this.is_pencil_draw.AutoSize = true;
            this.is_pencil_draw.ForeColor = System.Drawing.Color.Transparent;
            this.is_pencil_draw.Location = new System.Drawing.Point(806, 276);
            this.is_pencil_draw.Name = "is_pencil_draw";
            this.is_pencil_draw.Size = new System.Drawing.Size(15, 14);
            this.is_pencil_draw.TabIndex = 39;
            this.is_pencil_draw.UseVisualStyleBackColor = true;
            // 
            // pen_label
            // 
            this.pen_label.AutoSize = true;
            this.pen_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pen_label.Location = new System.Drawing.Point(556, 252);
            this.pen_label.Name = "pen_label";
            this.pen_label.Size = new System.Drawing.Size(128, 13);
            this.pen_label.TabIndex = 41;
            this.pen_label.Text = "Pencil Color/Kalem Rengi";
            // 
            // get_pen_color
            // 
            this.get_pen_color.FormattingEnabled = true;
            this.get_pen_color.Items.AddRange(new object[] {
            "Red/Kırmızı",
            "Blue/Mavi",
            "Orange/Turuncu",
            "Yellow/Sarı",
            "Purple/Mor",
            "Silver/Gümüş",
            "Gray/Gri"});
            this.get_pen_color.Location = new System.Drawing.Point(692, 249);
            this.get_pen_color.Name = "get_pen_color";
            this.get_pen_color.Size = new System.Drawing.Size(95, 21);
            this.get_pen_color.TabIndex = 40;
            this.get_pen_color.Text = "Red/Kırmızı";
            // 
            // pencil_width
            // 
            this.pencil_width.Location = new System.Drawing.Point(764, 274);
            this.pencil_width.Multiline = true;
            this.pencil_width.Name = "pencil_width";
            this.pencil_width.Size = new System.Drawing.Size(23, 19);
            this.pencil_width.TabIndex = 42;
            this.pencil_width.Text = "3,5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(619, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Pencil Width/Kalem Kalınlığı";
            // 
            // _2d
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(834, 562);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pencil_width);
            this.Controls.Add(this.pen_label);
            this.Controls.Add(this.get_pen_color);
            this.Controls.Add(this.is_pencil_draw);
            this.Controls.Add(this.pencil_draw_img);
            this.Controls.Add(this.TEST_DEBUG_BUTTON);
            this.Controls.Add(this.set_pos_corner);
            this.Controls.Add(this.open_data_button);
            this.Controls.Add(this.save_data_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endposy);
            this.Controls.Add(this.vectorcolor);
            this.Controls.Add(this.startdefine);
            this.Controls.Add(this.enddefine);
            this.Controls.Add(this.isdefstart);
            this.Controls.Add(this.isdefend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.defstart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.one_line);
            this.Controls.Add(this.over_origin);
            this.Controls.Add(this.bug_button);
            this.Controls.Add(this.cleaner_but);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x);
            this.Controls.Add(this.startposy);
            this.Controls.Add(this.startposx);
            this.Controls.Add(this.endposx);
            this.Controls.Add(this.endpos);
            this.Controls.Add(this.startpos);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(854, 604);
            this.MinimumSize = new System.Drawing.Size(854, 604);
            this.Name = "_2d";
            this.Text = "Vector Workshop_0.2 by iron1976";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_down);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_move);
            ((System.ComponentModel.ISupportInitialize)(this.pencil_draw_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label startpos;
        private System.Windows.Forms.Label endpos;
        private System.Windows.Forms.TextBox endposx;
        private System.Windows.Forms.TextBox startposx;
        private System.Windows.Forms.TextBox startposy;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cleaner_but;
        private System.Windows.Forms.Button bug_button;
        private System.Windows.Forms.TextBox one_line;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label defstart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox isdefend;
        private System.Windows.Forms.CheckBox isdefstart;
        private System.Windows.Forms.TextBox enddefine;
        private System.Windows.Forms.TextBox startdefine;
        private System.Windows.Forms.ComboBox vectorcolor;
        private System.Windows.Forms.TextBox endposy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button save_data_button;
        private System.Windows.Forms.Button open_data_button;
        private System.Windows.Forms.CheckBox set_pos_corner;
        private System.Windows.Forms.CheckBox over_origin;
        private System.Windows.Forms.Button TEST_DEBUG_BUTTON;
        private System.Windows.Forms.PictureBox pencil_draw_img;
        private System.Windows.Forms.CheckBox is_pencil_draw;
        private System.Windows.Forms.Label pen_label;
        private System.Windows.Forms.ComboBox get_pen_color;
        private System.Windows.Forms.TextBox pencil_width;
        private System.Windows.Forms.Label label7;
    }
}