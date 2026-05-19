using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RealStateAgency
{
    public partial class BuyerForm : Form
    {
        public Buyer NewBuyer { get; private set; } // Властивість для передачі готової форми покупця в головну форму


        // КОНСТРУКТОР ДЛЯ ДОДАВАННЯ
        public BuyerForm()
        {
            InitializeComponent();
        }

        // КОНСТРУКТОР ДЛЯ РЕДАГУВАННЯ
        public BuyerForm(Buyer editBuyer)
        {
            InitializeComponent();

            // Заповнюємо поля форми даними клієнта, якого передали
            txtName.Text = editBuyer.ClientName;
            txtPhone.Text = editBuyer.ClientPhone;
            txtTelegram.Text = editBuyer.Telegram;
            cmbDistrict.Text = editBuyer.DesiredDistrict;
            numMinRooms.Value = editBuyer.MinRooms;
            numMaxPrice.Value = editBuyer.MaxPrice;
            chkApartment.Checked = editBuyer.WantsApartment;
            chkHouse.Checked = editBuyer.WantsHouse;
        }

        // КНОПКА ЗБЕРЕЖЕННЯ
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
            string.IsNullOrWhiteSpace(txtPhone.Text) ||
            string.IsNullOrWhiteSpace(cmbDistrict.Text))
            {
                MessageBox.Show("Будь ласка, вкажіть ім'я клієнта, телефон та бажаний район!",
                                "Помилка заповнення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numMaxPrice.Value == 0 || numMinRooms.Value == 0)
            {
                MessageBox.Show("Бюджет та мінімальна кількість кімнат мають бути більшими за нуль!",
                                "Помилка заповнення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chkHouse.Checked && !chkApartment.Checked)
            {
                MessageBox.Show("Оберіть хоча б один тип житла (Квартира або Дім)!",
                                "Помилка заповнення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NewBuyer = new Buyer
            {
                ClientName = txtName.Text,
                ClientPhone = txtPhone.Text,
                Telegram = txtTelegram.Text,
                DesiredDistrict = cmbDistrict.Text,
                MinRooms = (int)numMinRooms.Value,
                MaxPrice = numMaxPrice.Value,
                WantsApartment = chkApartment.Checked,
                WantsHouse = chkHouse.Checked
            };


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // КНОПКА СКАСУВАННЯ
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // ДОВІДКА
        private void BuyerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                e.Handled = true;
                MessageBox.Show(
                    "ДОВІДКА: Анкета покупця\n\n" +
                    "Тут заповнюється інформація для анкети покупця.\n" +
                    "Заповніть усі контактні дані та вимоги до житла.\n" +
                    "- Увага: Ціна та кількість кімнат мають бути більше нуля.\n" +
                    "- Натисніть Enter для швидкого збереження, або Esc для виходу.",
                    "Довідка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
