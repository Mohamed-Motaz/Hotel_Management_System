namespace Frontend.ReceptionistForms
{
    partial class CheckOutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOutForm));
            this.label2 = new System.Windows.Forms.Label();
            this.RoomIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator43 = new Bunifu.Framework.UI.BunifuSeparator();
            this.CheckOutBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(236, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 561;
            this.label2.Text = "Checkout";
            // 
            // RoomIDTextBox
            // 
            this.RoomIDTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.RoomIDTextBox.Location = new System.Drawing.Point(190, 59);
            this.RoomIDTextBox.MaxLength = 20;
            this.RoomIDTextBox.Name = "RoomIDTextBox";
            this.RoomIDTextBox.Size = new System.Drawing.Size(231, 20);
            this.RoomIDTextBox.TabIndex = 560;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(89, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 559;
            this.label1.Text = "Room ID:";
            // 
            // bunifuSeparator43
            // 
            this.bunifuSeparator43.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator43.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.bunifuSeparator43.LineThickness = 2;
            this.bunifuSeparator43.Location = new System.Drawing.Point(12, 30);
            this.bunifuSeparator43.Name = "bunifuSeparator43";
            this.bunifuSeparator43.Size = new System.Drawing.Size(607, 10);
            this.bunifuSeparator43.TabIndex = 558;
            this.bunifuSeparator43.Transparency = 255;
            this.bunifuSeparator43.Vertical = false;
            // 
            // CheckOutBtn
            // 
            this.CheckOutBtn.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.CheckOutBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CheckOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CheckOutBtn.BorderRadius = 2;
            this.CheckOutBtn.ButtonText = "Checkout";
            this.CheckOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckOutBtn.DisabledColor = System.Drawing.Color.Gray;
            this.CheckOutBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.CheckOutBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.CheckOutBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("CheckOutBtn.Iconimage")));
            this.CheckOutBtn.Iconimage_right = null;
            this.CheckOutBtn.Iconimage_right_Selected = null;
            this.CheckOutBtn.Iconimage_Selected = null;
            this.CheckOutBtn.IconMarginLeft = 0;
            this.CheckOutBtn.IconMarginRight = 0;
            this.CheckOutBtn.IconRightVisible = true;
            this.CheckOutBtn.IconRightZoom = 0D;
            this.CheckOutBtn.IconVisible = true;
            this.CheckOutBtn.IconZoom = 80D;
            this.CheckOutBtn.IsTab = false;
            this.CheckOutBtn.Location = new System.Drawing.Point(161, 243);
            this.CheckOutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CheckOutBtn.Name = "CheckOutBtn";
            this.CheckOutBtn.Normalcolor = System.Drawing.Color.LightSteelBlue;
            this.CheckOutBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.CheckOutBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.CheckOutBtn.selected = false;
            this.CheckOutBtn.Size = new System.Drawing.Size(283, 95);
            this.CheckOutBtn.TabIndex = 562;
            this.CheckOutBtn.Text = "Checkout";
            this.CheckOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckOutBtn.Textcolor = System.Drawing.Color.White;
            this.CheckOutBtn.TextFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.CheckOutBtn.Click += new System.EventHandler(this.CheckOutBtn_Click);
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 380);
            this.Controls.Add(this.CheckOutBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoomIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator43);
            this.Name = "CheckOutForm";
            this.Text = "CheckOutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RoomIDTextBox;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator43;
        private Bunifu.Framework.UI.BunifuFlatButton CheckOutBtn;
    }
}