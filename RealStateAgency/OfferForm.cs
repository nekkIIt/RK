using System;
using System.Windows.Forms;

namespace RealStateAgency // Перевір, щоб назва збігалася з твоїм проектом
{
    public partial class OfferForm : Form
    {
        // Властивість для передачі готової квартири в головну форму
        public Offer NewOffer { get; private set; }

        // 1. КОНСТРУКТОР ДЛЯ ДОДАВАННЯ (порожня форма)
        public OfferForm()
        {
            InitializeComponent();
        }

        // 2. КОНСТРУКТОР ДЛЯ РЕДАГУВАННЯ (заповнюємо форму старими даними)
        public OfferForm(Offer editOffer)
        {
            InitializeComponent();

            // Заповнюємо поля форми даними з обраної квартири
            cmbDistrict.Text = editOffer.District; // Використовуємо ComboBox
            txtAddress.Text = editOffer.Address;
            numPrice.Value = editOffer.Price;
            numRooms.Value = editOffer.Rooms;
            numArea.Value = (decimal)editOffer.Area; // Конвертуємо double в decimal для лічильника
            cmbPropertyType.Text = editOffer.PropertyType; // Використовуємо ComboBox

            txtOwnerName.Text = editOffer.OwnerName;
            txtOwnerPhone.Text = editOffer.OwnerPhone;
            txtOwnerTelegram.Text = editOffer.OwnerTelegram; // Твоє нове поле!
        }

        // КНОПКА "ЗБЕРЕГТИ"
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Створюємо нову квартиру і пакуємо туди все, що ввів риєлтор
            NewOffer = new Offer
            {
                District = cmbDistrict.Text,
                Address = txtAddress.Text,
                Price = numPrice.Value,
                Rooms = (int)numRooms.Value,
                Area = (double)numArea.Value, // Зворотна конвертація з decimal у double
                PropertyType = cmbPropertyType.Text,
                OwnerName = txtOwnerName.Text,
                OwnerPhone = txtOwnerPhone.Text,
                OwnerTelegram = txtOwnerTelegram.Text // Твоє нове поле!
            };

            // Кажемо формі, що все успішно, і закриваємо її
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // КНОПКА "СКАСУВАТИ"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}