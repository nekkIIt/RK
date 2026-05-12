using System.ComponentModel;
using System.IO;          // Для работы с файлами
using System.Text.Json;    // Для превращения объектов в текст (сериализация)
namespace RealStateAgency
{
    public partial class Form1 : Form
    {
        BindingList<Offer> offersList = new BindingList<Offer>();
        BindingList<Buyer> buyersList = new BindingList<Buyer>();
        public Form1()
        {
            InitializeComponent();

            // Прив'язка даних
            dataGridView1.DataSource = offersList;
            dgvBuyers.DataSource = buyersList;

            // --- НАЛАШТУВАННЯ ТАБЛИЦІ ПРОПОЗИЦІЙ (dataGridView1) ---
            dataGridView1.Columns["Id"].Visible = false; // Ховаємо страшний ID
            dataGridView1.Columns["District"].HeaderText = "Район";
            dataGridView1.Columns["Address"].HeaderText = "Адреса";
            dataGridView1.Columns["Price"].HeaderText = "Ціна ($)";
            dataGridView1.Columns["Rooms"].HeaderText = "Кімнати";
            dataGridView1.Columns["Area"].HeaderText = "Площа (кв.м)";
            dataGridView1.Columns["PropertyType"].HeaderText = "Тип об'єкта";
            dataGridView1.Columns["OwnerName"].HeaderText = "Ім'я продавця";
            dataGridView1.Columns["OwnerPhone"].HeaderText = "Телефон";

            // --- НАЛАШТУВАННЯ ТАБЛИЦІ ПОКУПЦІВ (dgvBuyers) ---
            dgvBuyers.Columns["Id"].Visible = false; // Ховаємо страшний ID
            dgvBuyers.Columns["ClientName"].HeaderText = "Ім'я клієнта";
            dgvBuyers.Columns["ClientPhone"].HeaderText = "Телефон";
            dgvBuyers.Columns["Telegram"].HeaderText = "Телеграм";
            dgvBuyers.Columns["DesiredDistrict"].HeaderText = "Бажаний район";
            dgvBuyers.Columns["MaxPrice"].HeaderText = "Бюджет до ($)";
            dgvBuyers.Columns["MinRooms"].HeaderText = "Кімнат від";
            dgvBuyers.Columns["WantsHouse"].HeaderText = "Шукає дім";
            dgvBuyers.Columns["WantsApartment"].HeaderText = "Шукає квартиру";
            dataGridView1.Columns["OwnerTelegram"].HeaderText = "Телеграм";


            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddBuyer_Click(object sender, EventArgs e)
        {
            // 1. Створюємо екземпляр нашого нового віконця
            BuyerForm addForm = new BuyerForm();

            // 2. Відкриваємо його у режимі діалогу (щоб не можна було клікати повз нього)
            // і відразу перевіряємо, чи натиснув користувач "Зберегти" (DialogResult.OK)
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // 3. Якщо натиснув згоду - беремо готового клієнта з форми 
                // і додаємо його в наш "розумний список"
                buyersList.Add(addForm.NewBuyer);
            }
        }

        private void btnDeleteBuyer_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи взагалі вибрана якась строчка (щоб програма не вилетіла)
            if (dgvBuyers.CurrentRow != null)
            {
                // Викликаємо віконце з питанням (вимога методички)
                DialogResult result = MessageBox.Show(
                    "Ви впевнені, що хочете видалити цього клієнта?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                // Якщо риєлтор натиснув "Так"
                if (result == DialogResult.Yes)
                {
                    // Дізнаємось номер вибраної строчки і видаляємо її зі списку
                    int index = dgvBuyers.CurrentRow.Index;
                    buyersList.RemoveAt(index);
                }
            }
        }

        private void btnEditBuyer_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи вибрана строчка
            if (dgvBuyers.CurrentRow != null)
            {
                // Беремо номер вибраної строчки і дістаємо нашого клієнта зі списку
                int index = dgvBuyers.CurrentRow.Index;
                Buyer selectedBuyer = buyersList[index];

                // Відкриваємо форму, але використовуємо наш НОВИЙ конструктор (передаємо туди клієнта)
                BuyerForm editForm = new BuyerForm(selectedBuyer);

                // Якщо риєлтор щось змінив і натиснув "Зберегти"
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Просто замінюємо старого клієнта в списку на оновленого
                    // Таблиця сама миттєво перемалюється!
                    buyersList[index] = editForm.NewBuyer;
                }
            }
        }

        private void btnAddOffer_Click(object sender, EventArgs e)
        {
            // Створюємо нове вікно продавця
            OfferForm addForm = new OfferForm();

            // Якщо риєлтор зберіг дані
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // Додаємо нову квартиру в наш список (таблиця оновиться сама)
                offersList.Add(addForm.NewOffer);
                SaveData();
            }
        }

        private void btnEditOffer_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи виділена якась квартира в таблиці
            if (dataGridView1.CurrentRow != null)
            {
                // Беремо номер виділеної строчки
                int index = dataGridView1.CurrentRow.Index;
                // Дістаємо саму квартиру зі списку
                Offer selectedOffer = offersList[index];

                // Відкриваємо вікно редагування, передаючи туди старі дані
                OfferForm editForm = new OfferForm(selectedOffer);

                // Якщо риєлтор натиснув "Зберегти" після змін
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Замінюємо стару квартиру на нову
                    offersList[index] = editForm.NewOffer;
                    SaveData();
                }
            }
        }

        private void btnDeleteOffer_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи виділена квартира
            if (dataGridView1.CurrentRow != null)
            {
                // Питаємо підтвердження (вимога методички)
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
        // Метод для збереження всіх даних у файли
        private void SaveData()
        {
            try
            {
                // Налаштування, щоб JSON був гарним (з відступами), а не в один рядок
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

        // Метод для завантаження даних при старті програми
        private void LoadData()
        {
            try
            {
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

        private void btnFindMatches_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи вибраний покупець у таблиці
            if (dgvBuyers.CurrentRow != null)
            {
                // Беремо вибраного клієнта
                int index = dgvBuyers.CurrentRow.Index;
                Buyer selectedBuyer = buyersList[index];

                // Створюємо порожній список для збереження підходящих варіантів
                List<Offer> matchedOffers = new List<Offer>();

                // АЛГОРИТМ ПОШУКУ: Проходимось по всій базі пропозицій (квартир)
                foreach (Offer offer in offersList)
                {
                    // 1. Перевіряємо ціну (квартира дешевша або дорівнює бюджету)
                    bool priceMatch = offer.Price <= selectedBuyer.MaxPrice;

                    // 2. Перевіряємо кімнати (кімнат стільки ж або більше, ніж просить клієнт)
                    bool roomsMatch = offer.Rooms >= selectedBuyer.MinRooms;

                    // 3. Перевіряємо район (має збігатися)
                    bool districtMatch = offer.District == selectedBuyer.DesiredDistrict;

                    // 4. Перевіряємо тип житла (квартира чи дім)
                    bool typeMatch = false;
                    if (selectedBuyer.WantsApartment && offer.PropertyType == "Квартира") typeMatch = true;
                    if (selectedBuyer.WantsHouse && offer.PropertyType == "Дім") typeMatch = true;

                    // Якщо ВСІ умови виконуються — додаємо квартиру до результатів
                    if (priceMatch && roomsMatch && districtMatch && typeMatch)
                    {
                        matchedOffers.Add(offer);
                    }
                }

                // ВИВЕДЕННЯ РЕЗУЛЬТАТІВ
                if (matchedOffers.Count > 0)
                {
                    // Формуємо красивий текст з результатами
                    string message = $"Для клієнта {selectedBuyer.ClientName} знайдено {matchedOffers.Count} варіант(ів):\n\n";

                    foreach (Offer match in matchedOffers)
                    {
                        message += $"📍 {match.PropertyType}, {match.Address} | {match.Rooms} кімн. | {match.Price}$\n";
                        message += $"📞 Продавець: {match.OwnerName} ({match.OwnerPhone})\n";
                        message += $"----------------------------------\n";
                    }

                    MessageBox.Show(message, "Успішний підбір", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }


}
