namespace TheToyEmporium
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            receipt_UserControl11 = new Receipt_UserControl1();
            profile_UserControl11 = new Profile_UserControl1();
            checkOut_UserControl11 = new CheckOut_UserControl1();
            orderUserControl11 = new OrderUserControl1();
            homepage_UserControl1 = new Homepage_UserControl();
            createAcc_UserControl1 = new CreateAcc_UserControl();
            logIn_UserControl1 = new LogIn_UserControl();
            SuspendLayout();
            // 
            // receipt_UserControl11
            // 
            receipt_UserControl11.Location = new Point(197, 12);
            receipt_UserControl11.Name = "receipt_UserControl11";
            receipt_UserControl11.Size = new Size(439, 573);
            receipt_UserControl11.TabIndex = 0;
            // 
            // profile_UserControl11
            // 
            profile_UserControl11.BackgroundImage = (Image)resources.GetObject("profile_UserControl11.BackgroundImage");
            profile_UserControl11.BackgroundImageLayout = ImageLayout.Stretch;
            profile_UserControl11.Location = new Point(0, 0);
            profile_UserControl11.Name = "profile_UserControl11";
            profile_UserControl11.Size = new Size(816, 755);
            profile_UserControl11.TabIndex = 1;
            // 
            // checkOut_UserControl11
            // 
            checkOut_UserControl11.Location = new Point(197, 0);
            checkOut_UserControl11.Name = "checkOut_UserControl11";
            checkOut_UserControl11.Size = new Size(439, 573);
            checkOut_UserControl11.TabIndex = 2;
            // 
            // orderUserControl11
            // 
            orderUserControl11.BackColor = SystemColors.Control;
            orderUserControl11.BackgroundImage = (Image)resources.GetObject("orderUserControl11.BackgroundImage");
            orderUserControl11.BackgroundImageLayout = ImageLayout.Stretch;
            orderUserControl11.Location = new Point(0, 0);
            orderUserControl11.Name = "orderUserControl11";
            orderUserControl11.Size = new Size(816, 755);
            orderUserControl11.TabIndex = 3;
            // 
            // homepage_UserControl1
            // 
            homepage_UserControl1.BackgroundImage = (Image)resources.GetObject("homepage_UserControl1.BackgroundImage");
            homepage_UserControl1.BackgroundImageLayout = ImageLayout.Stretch;
            homepage_UserControl1.Location = new Point(0, 0);
            homepage_UserControl1.Name = "homepage_UserControl1";
            homepage_UserControl1.Size = new Size(816, 755);
            homepage_UserControl1.TabIndex = 4;
            // 
            // createAcc_UserControl1
            // 
            createAcc_UserControl1.Location = new Point(209, 15);
            createAcc_UserControl1.Name = "createAcc_UserControl1";
            createAcc_UserControl1.Size = new Size(436, 558);
            createAcc_UserControl1.TabIndex = 5;
            // 
            // logIn_UserControl1
            // 
            logIn_UserControl1.BackgroundImage = (Image)resources.GetObject("logIn_UserControl1.BackgroundImage");
            logIn_UserControl1.BackgroundImageLayout = ImageLayout.Stretch;
            logIn_UserControl1.Location = new Point(-14, 0);
            logIn_UserControl1.Name = "logIn_UserControl1";
            logIn_UserControl1.Size = new Size(816, 755);
            logIn_UserControl1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_plain_aesthetic_background_with_cool_wallpaper_image_914477;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 716);
            Controls.Add(logIn_UserControl1);
            Controls.Add(createAcc_UserControl1);
            Controls.Add(homepage_UserControl1);
            Controls.Add(orderUserControl11);
            Controls.Add(checkOut_UserControl11);
            Controls.Add(profile_UserControl11);
            Controls.Add(receipt_UserControl11);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Receipt_UserControl1 receipt_UserControl11;
        private Profile_UserControl1 profile_UserControl11;
        private CheckOut_UserControl1 checkOut_UserControl11;
        private OrderUserControl1 orderUserControl11;
        private Homepage_UserControl homepage_UserControl1;
        private CreateAcc_UserControl createAcc_UserControl1;
        private LogIn_UserControl logIn_UserControl1;
    }
}