using System;
using System.Windows.Forms;
using System.Linq;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ApiSample
{
    public partial class Form1 : Form
    {
        private CategoryDTO _selectedCategory;
        public readonly Api _proxy;

        public Form1()
        {
            InitializeComponent();

            // Fill in your actual API URL and Key here
            string url = "http://20.234.113.211:8097/";
            string key = "1-84895dcc-8953-4d9c-ad0e-17f567b4b7b5";

            _proxy = new Api(url, key);

            // Fetch all categories
            var categories = _proxy.CategoriesFindAll();

            // Check if API request was successful and categories exist
            if (categories.Content != null)
            {
                // Add all category names to the combobox
                foreach (var category in categories.Content)
                {
                    comboBox1.Items.Add(category.Name);
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(_proxy);
            form2.Show();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();

            string selectedCategoryName = comboBox1.SelectedItem.ToString();

            // Fetch all categories again
            var categories = _proxy.CategoriesFindAll();

            // Find the category by name
            var categorySnapshot = categories.Content?.FirstOrDefault(c => c.Name == selectedCategoryName);

            // Check if the category was found
            if (categorySnapshot != null)
            {
                // Fetch the full category information
                var category = _proxy.CategoriesFind(categorySnapshot.Bvin).Content;

                // Here we assume that the first page of products will suffice. 
                // If there are many products in the category, paging through the results may be necessary.
                var products = _proxy.ProductsFindForCategory(category.Bvin, 1, 100);

                // Check if the API request was successful and products exist in the category
                if (products.Content != null)
                {
                    // Add all product names in the category to the listbox
                    foreach (var product in products.Content.Products)
                    {
                        listBox1.Items.Add(product.ProductName);
                        textBox1.Text = category.Description.ToString();
                    }
                }

                // Set the _selectedCategory to the category that was found
                _selectedCategory = category;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (comboBox1.SelectedItem != null)
                {
                    string selectedCategoryName = comboBox1.SelectedItem.ToString();
                    // Fetch all categories again
                    var categories = _proxy.CategoriesFindAll();
                    // Find the category by name
                    var selectedCategorySnapshot = categories.Content?.FirstOrDefault(c => c.Name == selectedCategoryName);

                    if (selectedCategorySnapshot != null)
                    {
                        var selectedCategoryResponse = _proxy.CategoriesFind(selectedCategorySnapshot.Bvin);
                        if (selectedCategoryResponse.Content != null)
                        {
                            Form3 form3 = new Form3(_proxy, selectedCategoryResponse.Content);
                            form3.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a category before proceeding.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_selectedCategory == null)
            {
                MessageBox.Show("Please select a category to delete.");
                return;
            }

            // Fetch products in the selected category
            var categoryProducts = _proxy.ProductsFindForCategory(_selectedCategory.Bvin, 1, 100);

            if (categoryProducts.Content != null)
            {
                // Iterate over each product in the category
                foreach (var categoryProduct in categoryProducts.Content.Products)
                {
                    // Fetch the full product information
                    var product = _proxy.ProductsFind(categoryProduct.Bvin).Content;

                    // Restore the original price from the SiteCost property
                    product.SitePrice = product.SiteCost;

                    // Update the product
                    var updateResponse = _proxy.ProductsUpdate(product);

                    if (updateResponse.Errors.Count > 0)
                    {
                        MessageBox.Show($"There was an error restoring the original price for the product '{product.ProductName}'.");
                        // Log errors as needed...
                    }
                }
            }

            // Delete the category
            var deleteResponse = _proxy.CategoriesDelete(_selectedCategory.Bvin);

            if (deleteResponse.Errors.Count > 0)
            {
                MessageBox.Show("There was an error deleting the category.");
                // Log errors as needed...
            }
            else
            {
                MessageBox.Show("The category was successfully deleted.Choose an other discount");
                comboBox1.Items.Remove(_selectedCategory.Name);
                listBox1.Items.Clear();
                textBox1.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Clear the existing items from the combobox, listbox and textbox
            comboBox1.Items.Clear();
            listBox1.Items.Clear();
            textBox1.Clear();

            // Fetch all categories
            var categories = _proxy.CategoriesFindAll();

            //Check if API request was successful and categories exist
            if (categories.Content != null)
            {
                //Add all category names to the combobox
                foreach (var category in categories.Content)
                {
                    comboBox1.Items.Add(category.Name);
                }

                
                }

            }
    }
}