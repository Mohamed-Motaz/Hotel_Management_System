namespace Frontend
{
    partial class ResidentLoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResidentLoginForm));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.label24 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Silver;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(104, 89);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(251, 23);
            this.txtUser.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Silver;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPass.Location = new System.Drawing.Point(104, 118);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(251, 23);
            this.txtPass.TabIndex = 7;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.Silver;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(83, 62);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 13);
            this.lblWarning.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(119, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN | HOTEL MANAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 47);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Red;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 2;
            this.bunifuTileButton1.ImageZoom = 70;
            this.bunifuTileButton1.LabelPosition = 1;
            this.bunifuTileButton1.LabelText = "";
            this.bunifuTileButton1.Location = new System.Drawing.Point(439, 12);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(17, 16);
            this.bunifuTileButton1.TabIndex = 19;
            this.bunifuTileButton1.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.DimGray;
            this.label24.Location = new System.Drawing.Point(11, 89);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 18);
            this.label24.TabIndex = 493;
            this.label24.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(11, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 494;
            this.label2.Text = "Password:";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 2;
            this.bunifuFlatButton2.ButtonText = "Login";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(122, 181);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(198, 51);
            this.bunifuFlatButton2.TabIndex = 495;
            this.bunifuFlatButton2.Text = "Login";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton2.Click += new System.EventHandler(this.ResidentLoginButton_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 2;
            this.bunifuFlatButton1.ButtonText = "Sign up";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(122, 257);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(198, 48);
            this.bunifuFlatButton1.TabIndex = 496;
            this.bunifuFlatButton1.Text = "Sign up";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.ResidentSignUpButton_Click);
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 2;
            this.bunifuFlatButton7.ButtonText = "Back";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton7.Iconimage")));
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 60D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(11, 11);
            this.bunifuFlatButton7.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(90, 29);
            this.bunifuFlatButton7.TabIndex = 498;
            this.bunifuFlatButton7.Text = "Back";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton7.Click += new System.EventHandler(this.BackBtn);
            // 
            // ResidentLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(471, 335);
            this.Controls.Add(this.bunifuFlatButton7);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ResidentLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
    }
}

