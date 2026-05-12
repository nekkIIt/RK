namespace RealStateAgency
{
    partial class BuyerForm
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
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPhone = new TextBox();
            txtTelegram = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numMaxPrice = new NumericUpDown();
            numMinRooms = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            chkApartment = new CheckBox();
            chkHouse = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            cmbDistrict = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numMaxPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinRooms).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(322, 23);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 15);
            label1.TabIndex = 2;
            label1.Text = "Заповнення форми для покупця";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 83);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 3;
            label2.Text = "Ім'я";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 141);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(322, 23);
            txtPhone.TabIndex = 4;
            // 
            // txtTelegram
            // 
            txtTelegram.Location = new Point(12, 206);
            txtTelegram.Name = "txtTelegram";
            txtTelegram.Size = new Size(322, 23);
            txtTelegram.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 144);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "Телефон";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 209);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 8;
            label4.Text = "Телеграм";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(356, 270);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 9;
            label5.Text = "Район";
            // 
            // numMaxPrice
            // 
            numMaxPrice.Location = new Point(444, 80);
            numMaxPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numMaxPrice.Name = "numMaxPrice";
            numMaxPrice.Size = new Size(259, 23);
            numMaxPrice.TabIndex = 11;
            // 
            // numMinRooms
            // 
            numMinRooms.Location = new Point(444, 141);
            numMinRooms.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numMinRooms.Name = "numMinRooms";
            numMinRooms.Size = new Size(259, 23);
            numMinRooms.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(718, 83);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 13;
            label6.Text = "Бюджет до ($)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(718, 144);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 14;
            label7.Text = "Кімнат від";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(123, 47);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 15;
            label8.Text = "Контактні дані";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(553, 47);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 16;
            label9.Text = "Вимоги";
            // 
            // chkApartment
            // 
            chkApartment.AutoSize = true;
            chkApartment.Location = new Point(444, 271);
            chkApartment.Name = "chkApartment";
            chkApartment.Size = new Size(77, 19);
            chkApartment.TabIndex = 17;
            chkApartment.Text = "Квартира";
            chkApartment.UseVisualStyleBackColor = true;
            // 
            // chkHouse
            // 
            chkHouse.AutoSize = true;
            chkHouse.Location = new Point(657, 271);
            chkHouse.Name = "chkHouse";
            chkHouse.Size = new Size(46, 19);
            chkHouse.TabIndex = 18;
            chkHouse.Text = "Дім";
            chkHouse.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(158, 381);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(176, 23);
            btnSave.TabIndex = 19;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(409, 381);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(176, 23);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbDistrict
            // 
            cmbDistrict.FormattingEnabled = true;
            cmbDistrict.Items.AddRange(new object[] { "Шевченківський", "Київський", "Салтівський", "Холодногірський", "Новобаварський", "Основ'янський", "Слобідський", "Індустріальний", "Немишлянський" });
            cmbDistrict.Location = new Point(12, 267);
            cmbDistrict.Name = "cmbDistrict";
            cmbDistrict.Size = new Size(322, 23);
            cmbDistrict.TabIndex = 43;
            // 
            // BuyerForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbDistrict);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkHouse);
            Controls.Add(chkApartment);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(numMinRooms);
            Controls.Add(numMaxPrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTelegram);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "BuyerForm";
            Text = "BuyerForm";
            ((System.ComponentModel.ISupportInitialize)numMaxPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtPhone;
        private TextBox txtTelegram;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numMaxPrice;
        private NumericUpDown numMinRooms;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private CheckBox chkApartment;
        private CheckBox chkHouse;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cmbDistrict;
    }
}