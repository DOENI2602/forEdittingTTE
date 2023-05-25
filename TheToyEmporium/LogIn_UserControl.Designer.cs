namespace TheToyEmporium
{
    partial class LogIn_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            UserName__textBox = new TextBox();
            label3 = new Label();
            Password_textBox = new TextBox();
            linkLabel1 = new LinkLabel();
            LogIn_button = new Button();
            CreateAcc_button = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Brown_Vintage_Sketch_Craft_Brewery_Round_Logo;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(130, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 85);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(140, 103);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 2;
            label1.Text = "Log In";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 181);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 3;
            label2.Text = "UserName/Email:";
            // 
            // UserName__textBox
            // 
            UserName__textBox.Location = new Point(44, 208);
            UserName__textBox.Name = "UserName__textBox";
            UserName__textBox.Size = new Size(227, 23);
            UserName__textBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 248);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // Password_textBox
            // 
            Password_textBox.Location = new Point(44, 275);
            Password_textBox.Name = "Password_textBox";
            Password_textBox.Size = new Size(227, 23);
            Password_textBox.TabIndex = 6;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(44, 315);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(125, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "forgot your password?";
            // 
            // LogIn_button
            // 
            LogIn_button.BackColor = Color.DodgerBlue;
            LogIn_button.Location = new Point(104, 365);
            LogIn_button.Name = "LogIn_button";
            LogIn_button.Size = new Size(153, 53);
            LogIn_button.TabIndex = 8;
            LogIn_button.Text = "Log In";
            LogIn_button.UseVisualStyleBackColor = false;
            // 
            // CreateAcc_button
            // 
            CreateAcc_button.BackColor = Color.Lime;
            CreateAcc_button.Location = new Point(104, 452);
            CreateAcc_button.Name = "CreateAcc_button";
            CreateAcc_button.Size = new Size(153, 53);
            CreateAcc_button.TabIndex = 9;
            CreateAcc_button.Text = "Create Account";
            CreateAcc_button.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(CreateAcc_button);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LogIn_button);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(UserName__textBox);
            panel1.Controls.Add(Password_textBox);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(226, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 544);
            panel1.TabIndex = 10;
            // 
            // LogIn_UserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_plain_aesthetic_background_with_cool_wallpaper_image_914477;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel1);
            Name = "LogIn_UserControl";
            Size = new Size(816, 755);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private TextBox UserName__textBox;
        private Label label3;
        private TextBox Password_textBox;
        private LinkLabel linkLabel1;
        private Button LogIn_button;
        private Button CreateAcc_button;
        private Panel panel1;
    }
}
