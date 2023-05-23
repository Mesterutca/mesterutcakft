using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ApiSample
{
    public partial class Form2 : Form
    {
        Api _proxy = null;
        public Form2(Api proxy)
        {
            InitializeComponent();
            _proxy = proxy;
        }
 

        public void buttonCreateDiscount_Click(object sender, EventArgs e)
            {
            var existingCategories = _proxy.CategoriesFindAll();
            if (existingCategories.Content.Any(c => c.Name == textBoxDiscountName.Text))
            {
                MessageBox.Show("A category with this name already exists. Please choose a different name.");
                return;
            }

            // Check if the discount is a number between 1 and 100
            if (!int.TryParse(textBoxDiscountValue.Text, out int discount) || discount < 1 || discount > 100)
            {
                MessageBox.Show("Please enter a valid discount value between 1 and 100.");
                return;
            }
            var category = new CategoryDTO();
                // populate the category with the minimum information
                category.Name = textBoxDiscountName.Text;
                category.Description = textBoxDiscountValue.Text;
                category.MetaDescription = "kutya,macska,kacsa";
                ApiResponse<CategoryDTO> response = _proxy.CategoriesCreate(category);

            if (response.Errors.Count > 0)
            {
                MessageBox.Show("There was an error creating the category.");
                // Log errors as needed...
            }
            else
            {
                MessageBox.Show("Category created successfully.");
                this.Close();
            }
        }
     }
}
