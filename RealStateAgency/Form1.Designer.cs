namespace RealStateAgency
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnAddOffer = new Button();
            btnDeleteOffer = new Button();
            btnEditOffer = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            numericUpDown6 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            tabPage2 = new TabPage();
            dgvBuyers = new DataGridView();
            panel2 = new Panel();
            btnFindMatches = new Button();
            btnAddBuyer = new Button();
            btnDeleteBuyer = new Button();
            btnEditBuyer = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBuyers).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1968, 1079);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1960, 1051);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "База пропозицій";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(1954, 1045);
            splitContainer1.SplitterDistance = 1457;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1457, 1022);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddOffer);
            panel1.Controls.Add(btnDeleteOffer);
            panel1.Controls.Add(btnEditOffer);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1457, 23);
            panel1.TabIndex = 27;
            // 
            // btnAddOffer
            // 
            btnAddOffer.Location = new Point(0, 0);
            btnAddOffer.Name = "btnAddOffer";
            btnAddOffer.Size = new Size(158, 23);
            btnAddOffer.TabIndex = 26;
            btnAddOffer.Text = "Додати";
            btnAddOffer.UseVisualStyleBackColor = true;
            btnAddOffer.Click += btnAddOffer_Click;
            // 
            // btnDeleteOffer
            // 
            btnDeleteOffer.Location = new Point(310, 0);
            btnDeleteOffer.Name = "btnDeleteOffer";
            btnDeleteOffer.Size = new Size(158, 23);
            btnDeleteOffer.TabIndex = 24;
            btnDeleteOffer.Text = "Видалити";
            btnDeleteOffer.UseVisualStyleBackColor = true;
            btnDeleteOffer.Click += btnDeleteOffer_Click;
            // 
            // btnEditOffer
            // 
            btnEditOffer.Location = new Point(155, 0);
            btnEditOffer.Name = "btnEditOffer";
            btnEditOffer.Size = new Size(158, 23);
            btnEditOffer.TabIndex = 25;
            btnEditOffer.Text = "Редагувати";
            btnEditOffer.UseVisualStyleBackColor = true;
            btnEditOffer.Click += btnEditOffer_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numericUpDown6);
            groupBox1.Controls.Add(numericUpDown5);
            groupBox1.Controls.Add(numericUpDown4);
            groupBox1.Controls.Add(numericUpDown3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 1045);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фільтри";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(22, 808);
            button2.Name = "button2";
            button2.Size = new Size(158, 23);
            button2.TabIndex = 23;
            button2.Text = "Скинути";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(22, 762);
            button1.Name = "button1";
            button1.Size = new Size(158, 23);
            button1.TabIndex = 22;
            button1.Text = "Застосувати зміни";
            button1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(322, 541);
            label12.Name = "label12";
            label12.Size = new Size(22, 15);
            label12.TabIndex = 21;
            label12.Text = "До";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(322, 490);
            label11.Name = "label11";
            label11.Size = new Size(23, 15);
            label11.TabIndex = 20;
            label11.Text = "Від";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 446);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 19;
            label10.Text = "Площа";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 286);
            label9.Name = "label9";
            label9.Size = new Size(95, 15);
            label9.TabIndex = 18;
            label9.Text = "Кількість кімнат";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 149);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 17;
            label8.Text = "Ціна у доларах";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 32);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 16;
            label7.Text = "Розташування";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(322, 395);
            label6.Name = "label6";
            label6.Size = new Size(22, 15);
            label6.TabIndex = 15;
            label6.Text = "До";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 337);
            label5.Name = "label5";
            label5.Size = new Size(23, 15);
            label5.TabIndex = 14;
            label5.Text = "Від";
            // 
            // numericUpDown6
            // 
            numericUpDown6.Location = new Point(22, 539);
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(261, 23);
            numericUpDown6.TabIndex = 13;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(22, 488);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(261, 23);
            numericUpDown5.TabIndex = 12;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(22, 393);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(261, 23);
            numericUpDown4.TabIndex = 11;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(22, 335);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(261, 23);
            numericUpDown3.TabIndex = 10;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(237, 628);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(46, 19);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Дім";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(22, 628);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(77, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Квартира";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(322, 233);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 7;
            label4.Text = "До";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 186);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 6;
            label3.Text = "Від";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(22, 231);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(261, 23);
            numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(22, 178);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(261, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 112);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Адреса";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 63);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Район";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 23);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(22, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 23);
            comboBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvBuyers);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1960, 1051);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "База попиту";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvBuyers
            // 
            dgvBuyers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuyers.Dock = DockStyle.Fill;
            dgvBuyers.Location = new Point(3, 26);
            dgvBuyers.Name = "dgvBuyers";
            dgvBuyers.Size = new Size(1954, 1022);
            dgvBuyers.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnFindMatches);
            panel2.Controls.Add(btnAddBuyer);
            panel2.Controls.Add(btnDeleteBuyer);
            panel2.Controls.Add(btnEditBuyer);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1954, 23);
            panel2.TabIndex = 28;
            // 
            // btnFindMatches
            // 
            btnFindMatches.Location = new Point(465, 0);
            btnFindMatches.Name = "btnFindMatches";
            btnFindMatches.Size = new Size(158, 23);
            btnFindMatches.TabIndex = 27;
            btnFindMatches.Text = "Підібрати варіанти";
            btnFindMatches.UseVisualStyleBackColor = true;
            btnFindMatches.Click += btnFindMatches_Click;
            // 
            // btnAddBuyer
            // 
            btnAddBuyer.Location = new Point(0, 0);
            btnAddBuyer.Name = "btnAddBuyer";
            btnAddBuyer.Size = new Size(158, 23);
            btnAddBuyer.TabIndex = 26;
            btnAddBuyer.Text = "Додати";
            btnAddBuyer.UseVisualStyleBackColor = true;
            btnAddBuyer.Click += btnAddBuyer_Click;
            // 
            // btnDeleteBuyer
            // 
            btnDeleteBuyer.Location = new Point(310, 0);
            btnDeleteBuyer.Name = "btnDeleteBuyer";
            btnDeleteBuyer.Size = new Size(158, 23);
            btnDeleteBuyer.TabIndex = 24;
            btnDeleteBuyer.Text = "Видалити";
            btnDeleteBuyer.UseVisualStyleBackColor = true;
            btnDeleteBuyer.Click += btnDeleteBuyer_Click;
            // 
            // btnEditBuyer
            // 
            btnEditBuyer.Location = new Point(155, 0);
            btnEditBuyer.Name = "btnEditBuyer";
            btnEditBuyer.Size = new Size(158, 23);
            btnEditBuyer.TabIndex = 25;
            btnEditBuyer.Text = "Редагувати";
            btnEditBuyer.UseVisualStyleBackColor = true;
            btnEditBuyer.Click += btnEditBuyer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1966, 1079);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBuyers).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label4;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private NumericUpDown numericUpDown6;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button button2;
        private Button button1;
        private Button btnEditOffer;
        private Button btnDeleteOffer;
        private Button btnAddOffer;
        private Panel panel1;
        private Panel panel2;
        private Button btnAddBuyer;
        private Button btnDeleteBuyer;
        private Button btnEditBuyer;
        private DataGridView dgvBuyers;
        private Button btnFindMatches;
    }
}
