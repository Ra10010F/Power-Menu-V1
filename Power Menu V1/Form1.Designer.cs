namespace Power_Menu_V1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            rjButton1 = new CustomControls.RJControls.RJButton();
            imageList1 = new ImageList(components);
            rjButton2 = new CustomControls.RJControls.RJButton();
            rjButton3 = new CustomControls.RJControls.RJButton();
            rjButton4 = new CustomControls.RJControls.RJButton();
            rjButton5 = new CustomControls.RJControls.RJButton();
            rjButton6 = new CustomControls.RJControls.RJButton();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(255, 192, 192);
            rjButton1.BackgroundColor = Color.FromArgb(255, 192, 192);
            rjButton1.BorderColor = Color.Silver;
            rjButton1.BorderRadius = 15;
            rjButton1.BorderSize = 1;
            rjButton1.Cursor = Cursors.Hand;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjButton1.ForeColor = Color.Black;
            rjButton1.ImageAlign = ContentAlignment.MiddleLeft;
            rjButton1.ImageIndex = 3;
            rjButton1.ImageList = imageList1;
            rjButton1.Location = new Point(19, 21);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(255, 58);
            rjButton1.TabIndex = 0;
            rjButton1.Text = " Shutdown";
            rjButton1.TextColor = Color.Black;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "clock.png");
            imageList1.Images.SetKeyName(1, "moon.png");
            imageList1.Images.SetKeyName(2, "restart.png");
            imageList1.Images.SetKeyName(3, "shutdown.png");
            imageList1.Images.SetKeyName(4, "user.png");
            imageList1.Images.SetKeyName(5, "info.png");
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.FromArgb(255, 255, 192);
            rjButton2.BackgroundColor = Color.FromArgb(255, 255, 192);
            rjButton2.BorderColor = Color.Silver;
            rjButton2.BorderRadius = 15;
            rjButton2.BorderSize = 1;
            rjButton2.Cursor = Cursors.Hand;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjButton2.ForeColor = Color.Black;
            rjButton2.ImageAlign = ContentAlignment.MiddleLeft;
            rjButton2.ImageIndex = 2;
            rjButton2.ImageList = imageList1;
            rjButton2.Location = new Point(19, 90);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(255, 58);
            rjButton2.TabIndex = 1;
            rjButton2.Text = " Restart";
            rjButton2.TextColor = Color.Black;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.FromArgb(192, 192, 255);
            rjButton3.BackgroundColor = Color.FromArgb(192, 192, 255);
            rjButton3.BorderColor = Color.Silver;
            rjButton3.BorderRadius = 15;
            rjButton3.BorderSize = 1;
            rjButton3.Cursor = Cursors.Hand;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjButton3.ForeColor = Color.Black;
            rjButton3.ImageAlign = ContentAlignment.MiddleLeft;
            rjButton3.ImageIndex = 4;
            rjButton3.ImageList = imageList1;
            rjButton3.Location = new Point(19, 158);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(255, 58);
            rjButton3.TabIndex = 2;
            rjButton3.Text = " Signout";
            rjButton3.TextColor = Color.Black;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += rjButton3_Click;
            // 
            // rjButton4
            // 
            rjButton4.BackColor = Color.FromArgb(224, 224, 224);
            rjButton4.BackgroundColor = Color.FromArgb(224, 224, 224);
            rjButton4.BorderColor = Color.Silver;
            rjButton4.BorderRadius = 15;
            rjButton4.BorderSize = 1;
            rjButton4.Cursor = Cursors.Hand;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjButton4.ForeColor = Color.Black;
            rjButton4.ImageAlign = ContentAlignment.MiddleLeft;
            rjButton4.ImageIndex = 1;
            rjButton4.ImageList = imageList1;
            rjButton4.Location = new Point(19, 226);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new Size(255, 58);
            rjButton4.TabIndex = 3;
            rjButton4.Text = " Sleep";
            rjButton4.TextColor = Color.Black;
            rjButton4.UseVisualStyleBackColor = false;
            rjButton4.Click += rjButton4_Click;
            // 
            // rjButton5
            // 
            rjButton5.BackColor = Color.FromArgb(192, 255, 192);
            rjButton5.BackgroundColor = Color.FromArgb(192, 255, 192);
            rjButton5.BorderColor = Color.Silver;
            rjButton5.BorderRadius = 15;
            rjButton5.BorderSize = 1;
            rjButton5.Cursor = Cursors.Hand;
            rjButton5.FlatAppearance.BorderSize = 0;
            rjButton5.FlatStyle = FlatStyle.Flat;
            rjButton5.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjButton5.ForeColor = Color.Black;
            rjButton5.ImageAlign = ContentAlignment.MiddleLeft;
            rjButton5.ImageIndex = 0;
            rjButton5.ImageList = imageList1;
            rjButton5.Location = new Point(19, 294);
            rjButton5.Name = "rjButton5";
            rjButton5.Size = new Size(255, 58);
            rjButton5.TabIndex = 4;
            rjButton5.Text = " Hibernate";
            rjButton5.TextColor = Color.Black;
            rjButton5.UseVisualStyleBackColor = false;
            rjButton5.Click += rjButton5_Click;
            // 
            // rjButton6
            // 
            rjButton6.BackColor = Color.White;
            rjButton6.BackgroundColor = Color.White;
            rjButton6.BorderColor = Color.Silver;
            rjButton6.BorderRadius = 15;
            rjButton6.BorderSize = 1;
            rjButton6.Cursor = Cursors.Hand;
            rjButton6.FlatAppearance.BorderSize = 0;
            rjButton6.FlatStyle = FlatStyle.Flat;
            rjButton6.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjButton6.ForeColor = Color.Black;
            rjButton6.Image = (Image)resources.GetObject("rjButton6.Image");
            rjButton6.ImageAlign = ContentAlignment.MiddleLeft;
            rjButton6.Location = new Point(170, 361);
            rjButton6.Name = "rjButton6";
            rjButton6.Size = new Size(92, 32);
            rjButton6.TabIndex = 5;
            rjButton6.Text = "info";
            rjButton6.TextAlign = ContentAlignment.MiddleRight;
            rjButton6.TextColor = Color.Black;
            rjButton6.UseVisualStyleBackColor = false;
            rjButton6.Click += rjButton6_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(36, 371);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(124, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Fully Shutdown";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 413);
            Controls.Add(checkBox1);
            Controls.Add(rjButton6);
            Controls.Add(rjButton5);
            Controls.Add(rjButton4);
            Controls.Add(rjButton3);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            TopMost = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.RJButton rjButton1;
        private ImageList imageList1;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton rjButton4;
        private CustomControls.RJControls.RJButton rjButton5;
        private CustomControls.RJControls.RJButton rjButton6;
        private CheckBox checkBox1;
    }
}
