using ClassLibrary.Model;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Nodes;

namespace Desktop
{
    public partial class LibraryForm : Form
    {
        HttpClient client = new HttpClient();
        List<Kolcsonzo> kolcsonzok;
        Kolcsonzo selectedKolcsonzo;
        List<int> ids = new List<int>();
        int markedToRemove;

        public LibraryForm()
        {
            InitializeComponent();
            getData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BtnVisszahoz.Enabled = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVisszahoz_Click(object sender, EventArgs e)
        {
            deleteMarkedId();
        }

        private void ListBoxKolcsonzok_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ids.Clear();
            int selectedIndex = ListBoxKolcsonzok.SelectedIndex;
            if (selectedIndex >= 0)
            {
                selectedKolcsonzo = this.kolcsonzok[selectedIndex];
                ListBoxKolcsonzesek.Items.Clear();
                foreach (var item in selectedKolcsonzo.Kolcsonzes)
                {
                    ListBoxKolcsonzesek.Items.Add(item.Cim + " - " + item.Iro + " (" + item.Mufaj + ")";
                    this.ids.Add(item.Id);

                }

                ListBoxKolcsonzesek.Refresh();
            }
        }

        async void getData()
        {
            var kolcsonzoUrl = "https://localhost:7253/api/Kolcsonzo";
            try
            {
                HttpResponseMessage response = await this.client.GetAsync(kolcsonzoUrl);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    this.kolcsonzok = JsonConvert.DeserializeObject<List<Kolcsonzo>>(result);
                    foreach (var item in this.kolcsonzok)
                        ListBoxKolcsonzok.Items.Add(item.Nev);
                }
                else Console.WriteLine("Hiba az adatok betöltésében");

            } catch (Exception ex) { Console.WriteLine("Hiba az adatok elérésében! " + ex); }
        }

        private void ListBoxKolcsonzesek_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ListBoxKolcsonzesek.SelectedIndex;
            if(selectedIndex >= 0)  SwitchButton();
            this.markedToRemove = this.ids[selectedIndex];
        }

        private void SwitchButton()
        {
            if (!BtnVisszahoz.Enabled) BtnVisszahoz.Enabled = true;
            else BtnVisszahoz.Enabled = false;
        }

        async private void deleteMarkedId()
        {
            try
            {
                string url = $"https://localhost:7253/api/Kolcsonzes/{markedToRemove}";
                HttpResponseMessage response = await client.DeleteAsync(url);
                if (response.IsSuccessStatusCode) MessageBox.Show("A könyv ismét kikölcsönözhetõ");
                else MessageBox.Show($"Sajnos valami hiba történt: {response.StatusCode}");

            } catch (Exception ex) { Console.WriteLine("Hiba az adatbáziskapcsolatban! " + ex); }

            
        }

    }
}