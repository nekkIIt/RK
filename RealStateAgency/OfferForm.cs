using System;
using System.Windows.Forms;

namespace RealStateAgency 
{
    public partial class OfferForm : Form
    {
        
        public Offer NewOffer { get; private set; } // Властивість для передачі готової квартири в головну форму

        // КОНСТРУКТОР ДЛЯ ДОДАВАННЯ
        public OfferForm()
        {
            InitializeComponent(); // Відрисовка усіх компонентів 

            numPlotArea.Enabled = (cmbPropertyType.Text == "Дім"); // Перевірка на кнопку дім
        }

        // КОНСТРУКТОР ДЛЯ РЕДАГУВАННЯ 
        public OfferForm(Offer editOffer)
        {
            InitializeComponent(); // Відрисовка усіх компонентів

            // Заповнюємо поля форми даними з обраної квартири
            cmbDistrict.Text = editOffer.District; 
            txtAddress.Text = editOffer.Address;
            numPrice.Value = editOffer.Price;
            numRooms.Value = editOffer.Rooms;
            numArea.Value = (decimal)editOffer.Area; 
            cmbPropertyType.Text = editOffer.PropertyType;

            txtOwnerName.Text = editOffer.OwnerName;
            txtOwnerPhone.Text = editOffer.OwnerPhone;
            txtOwnerTelegram.Text = editOffer.OwnerTelegram; 
            numPlotArea.Value = (decimal)editOffer.PlotArea;

            numPlotArea.Enabled = (cmbPropertyType.Text == "Дім"); // Перевірка на кнопку дім
        }

        // КНОПКА ЗБЕРЕЖЕННЯ
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Створення нової квартири і заповнення її даними
            NewOffer = new Offer
            {
                District = cmbDistrict.Text,
                Address = txtAddress.Text,
                Price = numPrice.Value,
                Rooms = (int)numRooms.Value,
                Area = (double)numArea.Value,
                PropertyType = cmbPropertyType.Text,
                OwnerName = txtOwnerName.Text,
                OwnerPhone = txtOwnerPhone.Text,
                OwnerTelegram = txtOwnerTelegram.Text, 
                PlotArea = (double)numPlotArea.Value
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
        private void OfferForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                e.Handled = true;
                MessageBox.Show(
                    "ДОВІДКА: Анкета об'єкта\n\n" +
                    "Тут заповнюєтсья інформація про виставлене на продаж житло.\n" +
                    "Введіть характеристики квартири або будинку на продаж.\n" +
                    "- Обов'язково вкажіть правильний район з випадаючого списку.\n" +
                    "- Натисніть Enter для збереження.",
                    "Довідка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // МЕТОД ПЕРЕМИКАЧ ДЛЯ ПЛОЩІ ДІЛЯНКИ
        private void cmbPropertyType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Якщо обрано дім поле ділянки вмикається, інакше вимикається
            numPlotArea.Enabled = (cmbPropertyType.Text == "Дім");
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}