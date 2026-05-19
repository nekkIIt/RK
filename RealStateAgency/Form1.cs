using System.ComponentModel;
using System.IO;          
using System.Text.Json;    
namespace RealStateAgency
{
    public partial class Form1 : Form
    {
        // ТАБЛИЦІ ПРОПОЗИЦІЙ І ПОПИТУ
        BindingList<Offer> offersList = new BindingList<Offer>();
        BindingList<Buyer> buyersList = new BindingList<Buyer>();
        public Form1()
        {
            InitializeComponent();

            // Прив'язка даних
            dataGridView1.DataSource = offersList;
            dgvBuyers.DataSource = buyersList;

            // НАЛАШТУВАННЯ ВИГЛЯДУ ТАБЛИЦІ ПРОПОЗИЦІЙ dataGridView1
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns["Id"].Visible = false; 
            dataGridView1.Columns["District"].HeaderText = "Район";
            dataGridView1.Columns["Address"].HeaderText = "Адреса";
            dataGridView1.Columns["Price"].HeaderText = "Ціна ($)";
            dataGridView1.Columns["Rooms"].HeaderText = "Кімнати";
            dataGridView1.Columns["Area"].HeaderText = "Площа (кв.м)";
            dataGridView1.Columns["PropertyType"].HeaderText = "Тип об'єкта";
            dataGridView1.Columns["OwnerName"].HeaderText = "Ім'я продавця";
            dataGridView1.Columns["OwnerPhone"].HeaderText = "Телефон";

            // НАЛАШТУВАННЯ ВИГЛЯДУ ТАБЛИЦІ ПОКУПЦІВ dgvBuyers
            dgvBuyers.AllowUserToAddRows = false;
            dgvBuyers.Columns["Id"].Visible = false;
            dgvBuyers.Columns["ClientName"].HeaderText = "Ім'я клієнта";
            dgvBuyers.Columns["ClientPhone"].HeaderText = "Телефон";
            dgvBuyers.Columns["Telegram"].HeaderText = "Телеграм";
            dgvBuyers.Columns["DesiredDistrict"].HeaderText = "Бажаний район";
            dgvBuyers.Columns["MaxPrice"].HeaderText = "Бюджет до ($)";
            dgvBuyers.Columns["MinRooms"].HeaderText = "Кімнат від";
            dgvBuyers.Columns["WantsHouse"].HeaderText = "Шукає дім";
            dgvBuyers.Columns["WantsApartment"].HeaderText = "Шукає квартиру";
            dataGridView1.Columns["OwnerTelegram"].HeaderText = "Телеграм";
            dataGridView1.Columns["PlotArea"].HeaderText = "Ділянка (сотки)";


            LoadData();
        }


        // КНОПКА ДОДАВАННЯ ПОКУПЦЯ
        private void btnAddBuyer_Click(object sender, EventArgs e)
        {
           
            BuyerForm addForm = new BuyerForm();


            if (addForm.ShowDialog() == DialogResult.OK)
            {
                buyersList.Add(addForm.NewBuyer);
            }
        }
        
        // КНОПКА ВИДАЛЕННЯ ПОКУПЦЯ
        private void btnDeleteBuyer_Click(object sender, EventArgs e)
        {
            if (dgvBuyers.CurrentRow != null)
            {
                // Повторне підтвердження
                DialogResult result = MessageBox.Show(
                    "Ви впевнені, що хочете видалити цього клієнта?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);


                if (result == DialogResult.Yes)
                {
                    int index = dgvBuyers.CurrentRow.Index;
                    buyersList.RemoveAt(index);
                }
            }
        }

        // КНОПКА РЕДАГУВАННЯ ПОКУПЦЯ 
        private void btnEditBuyer_Click(object sender, EventArgs e)
        {
            if (dgvBuyers.CurrentRow != null)
            {
                // Беремо номер вибраної строчки і дістаємо нашого клієнта зі списку
                int index = dgvBuyers.CurrentRow.Index;
                Buyer selectedBuyer = buyersList[index];

                // Відкриваємо форму
                BuyerForm editForm = new BuyerForm(selectedBuyer);

                // Якщо риєлтор щось змінив і натиснув "Зберегти"
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Просто замінюємо старого клієнта в списку на оновленого
                    buyersList[index] = editForm.NewBuyer;
                }
            }
        }

        // КНОПКА ДОДАВАННЯ ЖИТЛА
        private void btnAddOffer_Click(object sender, EventArgs e)
        {

            OfferForm addForm = new OfferForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                offersList.Add(addForm.NewOffer);
                SaveData();
            }
        }

        // КНОПКА РЕДАГУВАННЯ ПОКУПЦЯ 
        private void btnEditOffer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Беремо номер виділеної строчки
                int index = dataGridView1.CurrentRow.Index;
                // Дістаємо саму квартиру зі списку
                Offer selectedOffer = offersList[index];

                // Відкриваємо вікно редагування, передаючи туди старі дані
                OfferForm editForm = new OfferForm(selectedOffer);


                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    offersList[index] = editForm.NewOffer;
                    SaveData();
                }
            }
        }

        // КНОПКА ВИДАЛЕННЯ ПОКУПЦЯ
        private void btnDeleteOffer_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                // Підтвердження
                DialogResult result = MessageBox.Show(
                    "Ви впевнені, що хочете видалити цю пропозицію?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Видаляємо за номером строчки
                    int index = dataGridView1.CurrentRow.Index;
                    offersList.RemoveAt(index);
                    SaveData();
                }
            }

        }
        // МЕТОД ЗБЕРЕЖЕННЯ ДАНИХ У ФАЙЛИ
        private void SaveData()
        {
            try
            {
                // Налаштування щоб JSON був з відступами а не в один рядок
                var options = new JsonSerializerOptions { WriteIndented = true };

                // Зберігаємо список пропозицій
                string offersJson = JsonSerializer.Serialize(offersList, options);
                File.WriteAllText("offers.json", offersJson);

                // Зберігаємо список покупців
                string buyersJson = JsonSerializer.Serialize(buyersList, options);
                File.WriteAllText("buyers.json", buyersJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні: {ex.Message}");
            }
        }

        // МЕТОД ДЛЯ ЗАВАНТАЖЕННЯ ДАНИХ У ПРОГРАМУ ПРИ СТАРТІ
        private void LoadData()
        {
            try
            {   //Завантаження продавців
                if (File.Exists("offers.json"))
                {
                    string json = File.ReadAllText("offers.json");
                    var list = JsonSerializer.Deserialize<List<Offer>>(json);
                    if (list != null)
                    {
                        offersList.Clear();
                        foreach (var item in list) offersList.Add(item);
                    }
                }
                // Завантаження покупців
                if (File.Exists("buyers.json"))
                {
                    string json = File.ReadAllText("buyers.json");
                    var list = JsonSerializer.Deserialize<List<Buyer>>(json);
                    if (list != null)
                    {
                        buyersList.Clear();
                        foreach (var item in list) buyersList.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні: {ex.Message}");
            }
        }
        

        // КНОПКА АВТОПІДБОРУ 
        private void btnFindMatches_Click(object sender, EventArgs e)
        {
            if (dgvBuyers.CurrentRow != null)
            {
                // Беремо вибраного клієнта
                int index = dgvBuyers.CurrentRow.Index;
                Buyer selectedBuyer = buyersList[index];


                List<Offer> matchedOffers = new List<Offer>(); //Список для підібраних варіантів

                // АЛГОРИТМ ПОШУКУ: Проходимось по всій базі пропозицій (квартир)
                foreach (Offer offer in offersList)
                {
                    // Перевіряємо ціну 
                    bool priceMatch = offer.Price <= selectedBuyer.MaxPrice;

                    // Перевіряємо кімнати 
                    bool roomsMatch = offer.Rooms >= selectedBuyer.MinRooms;

                    // Перевіряємо район 
                    bool districtMatch = offer.District == selectedBuyer.DesiredDistrict;

                    // Перевіряємо тип житла 
                    bool typeMatch = false;
                    if (selectedBuyer.WantsApartment && offer.PropertyType == "Квартира") typeMatch = true;
                    if (selectedBuyer.WantsHouse && offer.PropertyType == "Дім") typeMatch = true;

                    // Додаємо до списку варіант 
                    if (priceMatch && roomsMatch && districtMatch && typeMatch)
                    {
                        matchedOffers.Add(offer);
                    }
                }

                // ВИВЕДЕННЯ РЕЗУЛЬТАТІВ НА ВКЛАДЦІ ПРОДАВЦІВ
                if (matchedOffers.Count > 0)
                {

                    tabControl1.SelectedIndex = 0;

                    // Перетворюємо наш список знайдених квартир у формат для таблиці
                    var resultList = new System.ComponentModel.BindingList<Offer>(matchedOffers);

                    dataGridView1.DataSource = resultList;
                    MessageBox.Show(
                        $"Для клієнта {selectedBuyer.ClientName} знайдено {matchedOffers.Count} варіант(ів)!\n" +
                        "Вони вже відображені у таблиці. Щоб побачити всі квартири, натисніть кнопку 'Скинути' у фільтрах.",
                        "Успішний підбір",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("На жаль, за цими критеріями в базі нічого не знайдено.", "Результат підбору", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть покупця з таблиці перед пошуком.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // КНОПКА ДЛЯ ЗАСТОСУВАННЯ ФІЛЬТРІВ
        private void btnApplyFilter_Click(object sender, EventArgs e)
        {

            var filteredList = new System.ComponentModel.BindingList<Offer>(); // Створення списку в який записуємо підходящі варіанти

            foreach (var offer in offersList)
            {
                // Район
                if (!string.IsNullOrEmpty(cmbFilterDistrict.Text) && offer.District != cmbFilterDistrict.Text)
                    continue;

                // Адреса
                if (!string.IsNullOrEmpty(txtFilterAddress.Text) &&
                    !offer.Address.ToLower().Contains(txtFilterAddress.Text.ToLower()))
                    continue;

                // Ціна
                if (numFilterPriceFrom.Value > 0 && offer.Price < numFilterPriceFrom.Value) continue;
                if (numFilterPriceTo.Value > 0 && offer.Price > numFilterPriceTo.Value) continue;

                // Кімнати
                if (numFilterRoomsFrom.Value > 0 && offer.Rooms < numFilterRoomsFrom.Value) continue;
                if (numFilterRoomsTo.Value > 0 && offer.Rooms > numFilterRoomsTo.Value) continue;

                // Площа
                if (numFilterAreaFrom.Value > 0 && (decimal)offer.Area < numFilterAreaFrom.Value) continue;
                if (numFilterAreaTo.Value > 0 && (decimal)offer.Area > numFilterAreaTo.Value) continue;

                // Тип
                bool wantsApt = chkFilterApartment.Checked;
                bool wantsHouse = chkFilterHouse.Checked;

                if (wantsApt || wantsHouse) 
                {
                    if (wantsApt && !wantsHouse && offer.PropertyType != "Квартира") continue;
                    if (!wantsApt && wantsHouse && offer.PropertyType != "Дім") continue;
                }


                filteredList.Add(offer);
            }


            dataGridView1.DataSource = filteredList;
        }


        // КНОПКА ДЛЯ СКАСУВАННЯ ФІЛЬТРІВ 
        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            // Очищаємо всі поля
            cmbFilterDistrict.SelectedIndex = -1;
            cmbFilterDistrict.Text = "";
            txtFilterAddress.Clear();

            numFilterPriceFrom.Value = 0;
            numFilterPriceTo.Value = 0;
            numFilterRoomsFrom.Value = 0;
            numFilterRoomsTo.Value = 0;
            numFilterAreaFrom.Value = 0;
            numFilterAreaTo.Value = 0;

            chkFilterApartment.Checked = false;
            chkFilterHouse.Checked = false;


            dataGridView1.DataSource = offersList;
        }

        // МЕТОД ДЛЯ ДОВІДКИ
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                e.Handled = true; // Кажемо системі що ми самі обробили клавішу


                if (tabControl1.SelectedIndex == 0)
                {

                    MessageBox.Show(
                        "ДОВІДКА: База пропозицій\n\n" +
                        "Тут ви можете додавати об'єкти нерухомості на продаж.\n" +
                        "- Для пошуку використовуйте панель фільтрів праворуч та натискайте Enter.\n" +
                        "- Щоб додати новий об'єкт, натисніть кнопку 'Додати'.",
                        "Довідка - Пропозиції", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tabControl1.SelectedIndex == 1)
                {

                    MessageBox.Show(
                        "ДОВІДКА: База попиту\n\n" +
                        "Тут зберігаються дані клієнтів, які шукають житло.\n" +
                        "- Щоб знайти ідеальний варіант для клієнта, виділіть його в таблиці та натисніть 'Підібрати варіанти'.\n" +
                        "- Для редагування анкети виділіть клієнта і натисніть 'Редагувати'.",
                        "Довідка - Покупці", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }


}
