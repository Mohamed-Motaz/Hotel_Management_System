
namespace Frontend.Extras
{
    partial class ManageWorkers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageWorkers));
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.workersListButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.editOrDeleteWorkerButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.addWorkerButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(39, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 73;
            this.label1.Text = "Manage Workers";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(44, 81);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1025, 18);
            this.bunifuSeparator1.TabIndex = 74;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(237, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 75;
            this.label2.Text = "Control";
            // 
            // workersListButton
            // 
            this.workersListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.workersListButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.workersListButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(179)))), ((int)(((byte)(212)))));
            this.workersListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workersListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.workersListButton.ForeColor = System.Drawing.Color.White;
            this.workersListButton.Image = ((System.Drawing.Image)(resources.GetObject("workersListButton.Image")));
            this.workersListButton.ImagePosition = 20;
            this.workersListButton.ImageZoom = 50;
            this.workersListButton.LabelPosition = 41;
            this.workersListButton.LabelText = "Workers List";
            this.workersListButton.Location = new System.Drawing.Point(84, 163);
            this.workersListButton.Margin = new System.Windows.Forms.Padding(6);
            this.workersListButton.Name = "workersListButton";
            this.workersListButton.Size = new System.Drawing.Size(167, 155);
            this.workersListButton.TabIndex = 76;
            this.workersListButton.Click += new System.EventHandler(this.workersListButton_Click);
            // 
            // editOrDeleteWorkerButton
            // 
            this.editOrDeleteWorkerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.editOrDeleteWorkerButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.editOrDeleteWorkerButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(179)))), ((int)(((byte)(212)))));
            this.editOrDeleteWorkerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editOrDeleteWorkerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.editOrDeleteWorkerButton.ForeColor = System.Drawing.Color.White;
            this.editOrDeleteWorkerButton.Image = ((System.Drawing.Image)(resources.GetObject("editOrDeleteWorkerButton.Image")));
            this.editOrDeleteWorkerButton.ImagePosition = 20;
            this.editOrDeleteWorkerButton.ImageZoom = 50;
            this.editOrDeleteWorkerButton.LabelPosition = 41;
            this.editOrDeleteWorkerButton.LabelText = "Edit or Delete Worker";
            this.editOrDeleteWorkerButton.Location = new System.Drawing.Point(186, 344);
            this.editOrDeleteWorkerButton.Margin = new System.Windows.Forms.Padding(6);
            this.editOrDeleteWorkerButton.Name = "editOrDeleteWorkerButton";
            this.editOrDeleteWorkerButton.Size = new System.Drawing.Size(228, 158);
            this.editOrDeleteWorkerButton.TabIndex = 78;
            this.editOrDeleteWorkerButton.Click += new System.EventHandler(this.editOrDeleteWorkerButton_Click);
            // 
            // addWorkerButton
            // 
            this.addWorkerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addWorkerButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addWorkerButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(179)))), ((int)(((byte)(212)))));
            this.addWorkerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addWorkerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.addWorkerButton.ForeColor = System.Drawing.Color.White;
            this.addWorkerButton.Image = ((System.Drawing.Image)(resources.GetObject("addWorkerButton.Image")));
            this.addWorkerButton.ImagePosition = 20;
            this.addWorkerButton.ImageZoom = 50;
            this.addWorkerButton.LabelPosition = 41;
            this.addWorkerButton.LabelText = "Add Worker";
            this.addWorkerButton.Location = new System.Drawing.Point(311, 163);
            this.addWorkerButton.Margin = new System.Windows.Forms.Padding(6);
            this.addWorkerButton.Name = "addWorkerButton";
            this.addWorkerButton.Size = new System.Drawing.Size(167, 155);
            this.addWorkerButton.TabIndex = 79;
            this.addWorkerButton.Click += new System.EventHandler(this.addWorkerButton_Click);
            // 
            // ManageWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 744);
            this.Controls.Add(this.addWorkerButton);
            this.Controls.Add(this.editOrDeleteWorkerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workersListButton);
            this.Name = "ManageWorkers";
            this.Text = "ManageWorkers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuTileButton workersListButton;
        private Bunifu.Framework.UI.BunifuTileButton editOrDeleteWorkerButton;
        private Bunifu.Framework.UI.BunifuTileButton addWorkerButton;
    }
}