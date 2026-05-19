namespace RealStateAgency
{
    partial class OfferForm
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
            btnCancel = new Button();
            btnSave = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            numRooms = new NumericUpDown();
            numPrice = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtAddress = new TextBox();
            txtOwnerTelegram = new TextBox();
            txtOwnerPhone = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtOwnerName = new TextBox();
            cmbPropertyType = new ComboBox();
            label10 = new Label();
            cmbDistrict = new ComboBox();
            label11 = new Label();
            numArea = new NumericUpDown();
            label12 = new Label();
            label13 = new Label();
            numPlotArea = new NumericUpDown();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)numRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numArea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPlotArea).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(405, 381);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(176, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(154, 381);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(176, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(514, 47);
            label9.Name = "label9";
            label9.Size = new Size(94, 15);
            label9.TabIndex = 35;
            label9.Text = "Характеристика";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(119, 47);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 34;
            label8.Text = "Контактні дані";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(679, 123);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 33;
            label7.Text = "Кімнат ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(679, 83);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 32;
            label6.Text = "Ціна ($)";
            // 
            // numRooms
            // 
            numRooms.Location = new Point(405, 120);
            numRooms.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numRooms.Name = "numRooms";
            numRooms.Size = new Size(259, 23);
            numRooms.TabIndex = 6;
            // 
            // numPrice
            // 
            numPrice.Location = new Point(405, 80);
            numPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(259, 23);
            numPrice.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(316, 246);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 29;
            label5.Text = "Район";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(316, 167);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 28;
            label4.Text = "Телеграм";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 123);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 27;
            label3.Text = "Телефон";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(8, 288);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(291, 23);
            txtAddress.TabIndex = 4;
            // 
            // txtOwnerTelegram
            // 
            txtOwnerTelegram.Location = new Point(8, 159);
            txtOwnerTelegram.Name = "txtOwnerTelegram";
            txtOwnerTelegram.Size = new Size(291, 23);
            txtOwnerTelegram.TabIndex = 2;
            // 
            // txtOwnerPhone
            // 
            txtOwnerPhone.Location = new Point(8, 120);
            txtOwnerPhone.Name = "txtOwnerPhone";
            txtOwnerPhone.Size = new Size(291, 23);
            txtOwnerPhone.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 83);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 23;
            label2.Text = "Ім'я";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 15);
            label1.TabIndex = 22;
            label1.Text = "Заповнення форми для продавця";
            // 
            // txtOwnerName
            // 
            txtOwnerName.Location = new Point(8, 80);
            txtOwnerName.Name = "txtOwnerName";
            txtOwnerName.Size = new Size(291, 23);
            txtOwnerName.TabIndex = 0;
            // 
            // cmbPropertyType
            // 
            cmbPropertyType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPropertyType.FormattingEnabled = true;
            cmbPropertyType.Items.AddRange(new object[] { "Квартира", "Дім" });
            cmbPropertyType.Location = new Point(405, 206);
            cmbPropertyType.Name = "cmbPropertyType";
            cmbPropertyType.Size = new Size(259, 23);
            cmbPropertyType.TabIndex = 8;
            cmbPropertyType.SelectedIndexChanged += cmbPropertyType_SelectedIndexChanged_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(119, 206);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 41;
            label10.Text = "Адреса";
            // 
            // cmbDistrict
            // 
            cmbDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDistrict.FormattingEnabled = true;
            cmbDistrict.Items.AddRange(new object[] { "Шевченківський", "Київський", "Салтівський", "Холодногірський", "Новобаварський", "Основ'янський", "Слобідський", "Індустріальний", "Немишлянський" });
            cmbDistrict.Location = new Point(8, 243);
            cmbDistrict.Name = "cmbDistrict";
            cmbDistrict.Size = new Size(291, 23);
            cmbDistrict.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(316, 291);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 43;
            label11.Text = "Адреса";
            // 
            // numArea
            // 
            numArea.Location = new Point(405, 159);
            numArea.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numArea.Name = "numArea";
            numArea.Size = new Size(259, 23);
            numArea.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(679, 162);
            label12.Name = "label12";
            label12.Size = new Size(47, 15);
            label12.TabIndex = 45;
            label12.Text = "Площа";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(679, 209);
            label13.Name = "label13";
            label13.Size = new Size(27, 15);
            label13.TabIndex = 46;
            label13.Text = "Тип";
            // 
            // numPlotArea
            // 
            numPlotArea.Location = new Point(405, 246);
            numPlotArea.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPlotArea.Name = "numPlotArea";
            numPlotArea.Size = new Size(259, 23);
            numPlotArea.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(679, 251);
            label14.Name = "label14";
            label14.Size = new Size(92, 15);
            label14.TabIndex = 48;
            label14.Text = "Площа ділянки";
            label14.Click += label14_Click;
            // 
            // OfferForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(label14);
            Controls.Add(numPlotArea);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(numArea);
            Controls.Add(label11);
            Controls.Add(cmbDistrict);
            Controls.Add(label10);
            Controls.Add(cmbPropertyType);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(numRooms);
            Controls.Add(numPrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtAddress);
            Controls.Add(txtOwnerTelegram);
            Controls.Add(txtOwnerPhone);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOwnerName);
            KeyPreview = true;
            Name = "OfferForm";
            Text = "OfferForm";
            KeyDown += OfferForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)numRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numArea).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPlotArea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private NumericUpDown numRooms;
        private NumericUpDown numPrice;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtAddress;
        private TextBox txtOwnerTelegram;
        private TextBox txtOwnerPhone;
        private Label label2;
        private Label label1;
        private TextBox txtOwnerName;
        private ComboBox cmbPropertyType;
        private Label label10;
        private ComboBox cmbDistrict;
        private Label label11;
        private NumericUpDown numArea;
        private Label label12;
        private Label label13;
        private NumericUpDown numPlotArea;
        private Label label14;
    }
}