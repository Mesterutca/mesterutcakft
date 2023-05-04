using _3fazis.Models;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3fazis
{
    public partial class ÚjAkció : Form
    {
        private Form1 _form1;

        public ÚjAkció(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }
        public ÚjAkció()
        {
            InitializeComponent();
        }

        private void ÚjAkció_Load(object sender, EventArgs e)
        {

        }
        private bool AddNewAction(int actionNumber)
        {
            using (KozmetikaWebshopContext dbContext = new KozmetikaWebshopContext())
            {
                var existingAction = dbContext.Akciós.FirstOrDefault(a => a.AkcióNév == actionNumber);

                if (existingAction != null)
                {
                    return false;
                }

                int maxAkcióID = dbContext.Akciós.Max(a => a.AkcióId);
                int newAkcióID = maxAkcióID + 1;

                var newAction = new Akció
                {
                    AkcióId = newAkcióID,
                    AkcióNév = actionNumber,
                    Aktív = false,
                    Kedvezmény = int.Parse(textBox2.Text)
            };

                dbContext.Akciós.Add(newAction);
                dbContext.SaveChanges();
            }
            return true;
        }



        private void btnAddNewAction_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int actionNumber))
            {
                if (AddNewAction(actionNumber))
                {
                    MessageBox.Show("Az akció sikeresen hozzáadva!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Ez az akció már létezik. Kérlek, adj meg egy másik akciónevet.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kérlek, írj be egy egész számot az akciónévhez!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
            _form1.LoadActions();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
