
namespace Frontend.Extras
{
    partial class ManageResidents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageResidents));
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.residentsListButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.addResidentButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.editOrDeleteResidentButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(44, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 30);
            this.label1.TabIndex = 69;
            this.label1.Text = "Manage Residents";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(49, 86);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1025, 18);
            this.bunifuSeparator1.TabIndex = 70;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(241, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 71;
            this.label2.Text = "Control";
            // 
            // residentsListButton
            // 
            this.residentsListButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.residentsListButton.color = System.Drawing.Color.LightSteelBlue;
            this.residentsListButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.residentsListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.residentsListButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.residentsListButton.ForeColor = System.Drawing.Color.White;
            this.residentsListButton.Image = ((System.Drawing.Image)(resources.GetObject("residentsListButton.Image")));
            this.residentsListButton.ImagePosition = 24;
            this.residentsListButton.ImageZoom = 50;
            this.residentsListButton.LabelPosition = 49;
            this.residentsListButton.LabelText = "Residents List";
            this.residentsListButton.Location = new System.Drawing.Point(95, 161);
            this.residentsListButton.Margin = new System.Windows.Forms.Padding(6);
            this.residentsListButton.Name = "residentsListButton";
            this.residentsListButton.Size = new System.Drawing.Size(236, 168);
            this.residentsListButton.TabIndex = 72;
            this.residentsListButton.Click += new System.EventHandler(this.residentsListButton_Click);
            // 
            // addResidentButton
            // 
            this.addResidentButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addResidentButton.color = System.Drawing.Color.LightSteelBlue;
            this.addResidentButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.addResidentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addResidentButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.addResidentButton.ForeColor = System.Drawing.Color.White;
            this.addResidentButton.Image = ((System.Drawing.Image)(resources.GetObject("addResidentButton.Image")));
            this.addResidentButton.ImagePosition = 24;
            this.addResidentButton.ImageZoom = 40;
            this.addResidentButton.LabelPosition = 49;
            this.addResidentButton.LabelText = "Add Resident";
            this.addResidentButton.Location = new System.Drawing.Point(353, 161);
            this.addResidentButton.Margin = new System.Windows.Forms.Padding(6);
            this.addResidentButton.Name = "addResidentButton";
            this.addResidentButton.Size = new System.Drawing.Size(236, 168);
            this.addResidentButton.TabIndex = 87;
            this.addResidentButton.Click += new System.EventHandler(this.addResidentButton_Click);
            // 
            // editOrDeleteResidentButton
            // 
            this.editOrDeleteResidentButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.editOrDeleteResidentButton.color = System.Drawing.Color.LightSteelBlue;
            this.editOrDeleteResidentButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.editOrDeleteResidentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editOrDeleteResidentButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.editOrDeleteResidentButton.ForeColor = System.Drawing.Color.White;
            this.editOrDeleteResidentButton.Image = ((System.Drawing.Image)(resources.GetObject("editOrDeleteResidentButton.Image")));
            this.editOrDeleteResidentButton.ImagePosition = 24;
            this.editOrDeleteResidentButton.ImageZoom = 40;
            this.editOrDeleteResidentButton.LabelPosition = 49;
            this.editOrDeleteResidentButton.LabelText = "Edit or Delete Resident";
            this.editOrDeleteResidentButton.Location = new System.Drawing.Point(208, 341);
            this.editOrDeleteResidentButton.Margin = new System.Windows.Forms.Padding(6);
            this.editOrDeleteResidentButton.Name = "editOrDeleteResidentButton";
            this.editOrDeleteResidentButton.Size = new System.Drawing.Size(236, 168);
            this.editOrDeleteResidentButton.TabIndex = 86;
            this.editOrDeleteResidentButton.Click += new System.EventHandler(this.editOrDeleteResidentButton_Click);
            // 
            // ManageResidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 744);
            this.Controls.Add(this.addResidentButton);
            this.Controls.Add(this.editOrDeleteResidentButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.residentsListButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageResidents";
            this.Text = "ManageClinicPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuTileButton residentsListButton;
        private Bunifu.Framework.UI.BunifuTileButton addResidentButton;
        private Bunifu.Framework.UI.BunifuTileButton editOrDeleteResidentButton;
    }
}