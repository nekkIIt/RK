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
        public Buyer NewBuyer { get; private set; }

        public BuyerForm()
        {
            InitializeComponent();
        }
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


        private void btnSave_Click(object sender, EventArgs e)
        {
            NewBuyer = new Buyer
            {
                ClientName = txtName.Text,
                ClientPhone = txtPhone.Text,
                Telegram = txtTelegram.Text,
                DesiredDistrict = cmbDistrict.Text,

                // Для чисел беремо властивість Value і конвертуємо у правильний формат
                MinRooms = (int)numMinRooms.Value,
                MaxPrice = numMaxPrice.Value,

                // Для галочок беремо властивість Checked (вона повертає true або false)
                WantsApartment = chkApartment.Checked,
                WantsHouse = chkHouse.Checked
            };

            // 2. Кажемо програмі, що форма закривається з позитивним результатом (Згода)
            this.DialogResult = DialogResult.OK;
            // 3. Закриваємо це маленьке віконечко
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
