
namespace Frontend.ReceptionistForms
{
    partial class EditOrDeleteReservation
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
            this.label22 = new System.Windows.Forms.Label();
            this.bunifuSeparator43 = new Bunifu.Framework.UI.BunifuSeparator();
            this.ResidentIDTextBox = new System.Windows.Forms.TextBox();
            this.RoomTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.StartDateDatepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.TotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.NumberofNightsTextBox = new System.Windows.Forms.TextBox();
            this.RoomIDTextBox = new System.Windows.Forms.TextBox();
            this.DeleteReservationBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ClearBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EditReservationBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(346, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 18);
            this.label22.TabIndex = 496;
            this.label22.Text = "Edit Reservation";
            // 
            // bunifuSeparator43
            // 
            this.bunifuSeparator43.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator43.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.bunifuSeparator43.LineThickness = 2;
            this.bunifuSeparator43.Location = new System.Drawing.Point(41, 39);
            this.bunifuSeparator43.Name = "bunifuSeparator43";
            this.bunifuSeparator43.Size = new System.Drawing.Size(725, 10);
            this.bunifuSeparator43.TabIndex = 495;
            this.bunifuSeparator43.Transparency = 255;
            this.bunifuSeparator43.Vertical = false;
            // 
            // ResidentIDTextBox
            // 
            this.ResidentIDTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ResidentIDTextBox.Location = new System.Drawing.Point(367, 65);
            this.ResidentIDTextBox.MaxLength = 20;
            this.ResidentIDTextBox.Name = "ResidentIDTextBox";
            this.ResidentIDTextBox.Size = new System.Drawing.Size(231, 20);
            this.ResidentIDTextBox.TabIndex = 543;
            // 
            // RoomTypeComboBox
            // 
            this.RoomTypeComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.RoomTypeComboBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomTypeComboBox.FormattingEnabled = true;
            this.RoomTypeComboBox.Location = new System.Drawing.Point(161, 257);
            this.RoomTypeComboBox.Name = "RoomTypeComboBox";
            this.RoomTypeComboBox.Size = new System.Drawing.Size(541, 21);
            this.RoomTypeComboBox.TabIndex = 542;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(17, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 541;
            this.label5.Text = "Total Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(17, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 540;
            this.label4.Text = "Room Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(17, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 539;
            this.label3.Text = "Number Of Nights:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(19, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 538;
            this.label2.Text = "Room ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(266, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 537;
            this.label1.Text = "Resident ID:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.DimGray;
            this.label24.Location = new System.Drawing.Point(245, 118);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 18);
            this.label24.TabIndex = 536;
            this.label24.Text = "Start Date: ";
            // 
            // StartDateDatepicker
            // 
            this.StartDateDatepicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.StartDateDatepicker.BorderRadius = 0;
            this.StartDateDatepicker.ForeColor = System.Drawing.Color.White;
            this.StartDateDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.StartDateDatepicker.FormatCustom = null;
            this.StartDateDatepicker.Location = new System.Drawing.Point(338, 115);
            this.StartDateDatepicker.Name = "StartDateDatepicker";
            this.StartDateDatepicker.Size = new System.Drawing.Size(324, 35);
            this.StartDateDatepicker.TabIndex = 535;
            this.StartDateDatepicker.Value = new System.DateTime(2018, 4, 3, 23, 29, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(406, 115);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 534;
            // 
            // TotalPriceTextBox
            // 
            this.TotalPriceTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TotalPriceTextBox.Location = new System.Drawing.Point(162, 329);
            this.TotalPriceTextBox.MaxLength = 20;
            this.TotalPriceTextBox.Name = "TotalPriceTextBox";
            this.TotalPriceTextBox.Size = new System.Drawing.Size(541, 20);
            this.TotalPriceTextBox.TabIndex = 533;
            // 
            // NumberofNightsTextBox
            // 
            this.NumberofNightsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.NumberofNightsTextBox.Location = new System.Drawing.Point(162, 292);
            this.NumberofNightsTextBox.MaxLength = 20;
            this.NumberofNightsTextBox.Name = "NumberofNightsTextBox";
            this.NumberofNightsTextBox.Size = new System.Drawing.Size(540, 20);
            this.NumberofNightsTextBox.TabIndex = 532;
            // 
            // RoomIDTextBox
            // 
            this.RoomIDTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.RoomIDTextBox.Location = new System.Drawing.Point(163, 225);
            this.RoomIDTextBox.MaxLength = 20;
            this.RoomIDTextBox.Name = "RoomIDTextBox";
            this.RoomIDTextBox.Size = new System.Drawing.Size(541, 20);
            this.RoomIDTextBox.TabIndex = 531;
            // 
            // DeleteReservationBtn
            // 
            this.DeleteReservationBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.DeleteReservationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.DeleteReservationBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteReservationBtn.BorderRadius = 2;
            this.DeleteReservationBtn.ButtonText = "Delete";
            this.DeleteReservationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteReservationBtn.DisabledColor = System.Drawing.Color.Gray;
            this.DeleteReservationBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DeleteReservationBtn.Iconimage = null;
            this.DeleteReservationBtn.Iconimage_right = null;
            this.DeleteReservationBtn.Iconimage_right_Selected = null;
            this.DeleteReservationBtn.Iconimage_Selected = null;
            this.DeleteReservationBtn.IconMarginLeft = 0;
            this.DeleteReservationBtn.IconMarginRight = 0;
            this.DeleteReservationBtn.IconRightVisible = true;
            this.DeleteReservationBtn.IconRightZoom = 0D;
            this.DeleteReservationBtn.IconVisible = true;
            this.DeleteReservationBtn.IconZoom = 90D;
            this.DeleteReservationBtn.IsTab = false;
            this.DeleteReservationBtn.Location = new System.Drawing.Point(370, 454);
            this.DeleteReservationBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteReservationBtn.Name = "DeleteReservationBtn";
            this.DeleteReservationBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.DeleteReservationBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(76)))));
            this.DeleteReservationBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.DeleteReservationBtn.selected = false;
            this.DeleteReservationBtn.Size = new System.Drawing.Size(92, 33);
            this.DeleteReservationBtn.TabIndex = 546;
            this.DeleteReservationBtn.Text = "Delete";
            this.DeleteReservationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteReservationBtn.Textcolor = System.Drawing.Color.White;
            this.DeleteReservationBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteReservationBtn.Click += new System.EventHandler(this.DeleteReservationBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearBtn.BorderRadius = 2;
            this.ClearBtn.ButtonText = "Clear";
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ClearBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ClearBtn.Iconimage = null;
            this.ClearBtn.Iconimage_right = null;
            this.ClearBtn.Iconimage_right_Selected = null;
            this.ClearBtn.Iconimage_Selected = null;
            this.ClearBtn.IconMarginLeft = 0;
            this.ClearBtn.IconMarginRight = 0;
            this.ClearBtn.IconRightVisible = true;
            this.ClearBtn.IconRightZoom = 0D;
            this.ClearBtn.IconVisible = true;
            this.ClearBtn.IconZoom = 90D;
            this.ClearBtn.IsTab = false;
            this.ClearBtn.Location = new System.Drawing.Point(510, 454);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.ClearBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(41)))), ((int)(((byte)(37)))));
            this.ClearBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ClearBtn.selected = false;
            this.ClearBtn.Size = new System.Drawing.Size(92, 33);
            this.ClearBtn.TabIndex = 545;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClearBtn.Textcolor = System.Drawing.Color.White;
            this.ClearBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // EditReservationBtn
            // 
            this.EditReservationBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.EditReservationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.EditReservationBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditReservationBtn.BorderRadius = 2;
            this.EditReservationBtn.ButtonText = "Edit";
            this.EditReservationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditReservationBtn.DisabledColor = System.Drawing.Color.Gray;
            this.EditReservationBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.EditReservationBtn.Iconimage = null;
            this.EditReservationBtn.Iconimage_right = null;
            this.EditReservationBtn.Iconimage_right_Selected = null;
            this.EditReservationBtn.Iconimage_Selected = null;
            this.EditReservationBtn.IconMarginLeft = 0;
            this.EditReservationBtn.IconMarginRight = 0;
            this.EditReservationBtn.IconRightVisible = true;
            this.EditReservationBtn.IconRightZoom = 0D;
            this.EditReservationBtn.IconVisible = true;
            this.EditReservationBtn.IconZoom = 90D;
            this.EditReservationBtn.IsTab = false;
            this.EditReservationBtn.Location = new System.Drawing.Point(233, 454);
            this.EditReservationBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditReservationBtn.Name = "EditReservationBtn";
            this.EditReservationBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.EditReservationBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(76)))));
            this.EditReservationBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.EditReservationBtn.selected = false;
            this.EditReservationBtn.Size = new System.Drawing.Size(92, 33);
            this.EditReservationBtn.TabIndex = 544;
            this.EditReservationBtn.Text = "Edit";
            this.EditReservationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditReservationBtn.Textcolor = System.Drawing.Color.White;
            this.EditReservationBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditReservationBtn.Click += new System.EventHandler(this.EditReservationBtn_Click);
            // 
            // EditOrDeleteReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 500);
            this.Controls.Add(this.DeleteReservationBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.EditReservationBtn);
            this.Controls.Add(this.ResidentIDTextBox);
            this.Controls.Add(this.RoomTypeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.StartDateDatepicker);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.TotalPriceTextBox);
            this.Controls.Add(this.NumberofNightsTextBox);
            this.Controls.Add(this.RoomIDTextBox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.bunifuSeparator43);
            this.Name = "EditOrDeleteReservation";
            this.Text = "EditOrDeleteReservation";
            this.Load += new System.EventHandler(this.EditOrDeleteReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label22;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator43;
        private System.Windows.Forms.TextBox ResidentIDTextBox;
        private System.Windows.Forms.ComboBox RoomTypeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label24;
        private Bunifu.Framework.UI.BunifuDatepicker StartDateDatepicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox TotalPriceTextBox;
        private System.Windows.Forms.TextBox NumberofNightsTextBox;
        private System.Windows.Forms.TextBox RoomIDTextBox;
        private Bunifu.Framework.UI.BunifuFlatButton DeleteReservationBtn;
        private Bunifu.Framework.UI.BunifuFlatButton ClearBtn;
        private Bunifu.Framework.UI.BunifuFlatButton EditReservationBtn;
    }
}