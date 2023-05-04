using _3fazis.Models;
using Microsoft.VisualBasic.Devices;

namespace _3fazis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadProducts();
            LoadActions();
            CalculateAndDisplayResult();
        }

        private void LoadProducts()
        {
            using (KozmetikaWebshopContext dbContext = new KozmetikaWebshopContext())
            {
                listBox1.Items.Clear();
                var products = dbContext.Termékeks.ToList();
                foreach (var product in products)
                {
                    listBox1.Items.Add(product.Nev);
                }
            }
        }
        public void LoadActions()
        {
            using (KozmetikaWebshopContext dbContext = new KozmetikaWebshopContext())
            {
                var actions = dbContext.Akciós.ToList();
                comboBox1.DataSource = actions;
                comboBox1.DisplayMember = "AkcióNév";
            }
            UpdateCheckBoxState();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÚjAkció újAkció = new ÚjAkció(this);
            újAkció.Show();
        }
        public void UpdateCheckBoxState()
        {
            if (comboBox1.SelectedItem != null)
            {
                var selectedAction = (Akció)comboBox1.SelectedItem;
                checkBox1.Checked = selectedAction.Aktív ?? false; // Default érték: false, ha az Aktiv NULL
            }
            else
            {
                checkBox1.Checked = false;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCheckBoxState();
            {
                // A kiválasztott elem átadása a TextBox2-nek
                textBoxtermekneve.Text = comboBox1.SelectedItem.ToString();

                // Display the selected action's name in textBoxAkcionev and discount in textBoxKedvezmeny
                if (comboBox1.SelectedItem != null)
                {
                    var selectedAction = (Akció)comboBox1.SelectedItem;
                    textBoxtermekneve.Text = selectedAction.AkcióNév.ToString();
                    textBoxkedvezmeny.Text = selectedAction.Kedvezmény.ToString();
                }
                else
                {
                    textBoxtermekneve.Text = "";
                    textBoxkedvezmeny.Text = "";
                }

                UpdateCheckBoxState();
                CalculateAndDisplayResult();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var selectedAction = (Akció)comboBox1.SelectedItem;
                using (KozmetikaWebshopContext dbContext = new KozmetikaWebshopContext())
                {
                    var actionToUpdate = dbContext.Akciós.FirstOrDefault(a => a.AkcióId == selectedAction.AkcióId);
                    if (actionToUpdate != null)
                    {
                        actionToUpdate.Aktív = checkBox1.Checked;
                        dbContext.SaveChanges();
                    }
                }
            }
            CalculateAndDisplayResult();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                // A kiválasztott elem átadása a TextBox1-nek
                textBoxeredetiar.Text = listBox1.SelectedItem.ToString();

                // Find the selected product's price and display it in textBoxEredetiAr
                string selectedProductName = listBox1.SelectedItem.ToString();
                using (KozmetikaWebshopContext dbContext = new KozmetikaWebshopContext())
                {
                    var selectedProduct = dbContext.Termékeks.FirstOrDefault(p => p.Nev == selectedProductName);
                    if (selectedProduct != null)
                    {
                        textBoxeredetiar.Text = selectedProduct.Ar.ToString();
                    }
                    else
                    {
                        textBoxeredetiar.Text = "";
                    }
                }
            }
            CalculateAndDisplayResult();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void CalculateAndDisplayResult()
        {
            if (!string.IsNullOrEmpty(textBoxeredetiar.Text) && !string.IsNullOrEmpty(textBoxkedvezmeny.Text) && checkBox1.Checked == true)
            {
                int ar =int.Parse(textBoxeredetiar.Text);
                int kedvezmeny = int.Parse(textBoxkedvezmeny.Text);

                int result = ar * (100-kedvezmeny);
                int akciosar = result / 100;
                textBoxakciosar.Text = akciosar.ToString();
            }
            else
            {
                textBoxakciosar.Text = "Valami nem stimmel";
            }
        }
    }
}