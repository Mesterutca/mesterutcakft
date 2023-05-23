using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1.Client;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

namespace ApiSample
{
    public partial class Form3 : Form
    {
        private readonly Api _proxy;
        private readonly CategoryDTO _selectedCategory;

        public Form3(Api proxy, CategoryDTO selectedCategory)
        {
            InitializeComponent();

            _proxy = proxy;
            _selectedCategory = selectedCategory;

            LoadProducts();
        }

        private void LoadProducts()
        {
            // Fetch all products
            var allProducts = _proxy.ProductsFindAll();

            // Fetch products in the selected category
            var categoryProducts = _proxy.ProductsFindForCategory(_selectedCategory.Bvin, 1, 100);

            // Convert category products to a HashSet for efficient lookup
            var categoryProductNames = new HashSet<string>(categoryProducts.Content.Products.Select(p => p.ProductName));

            if (allProducts.Content != null)
            {
                foreach (var product in allProducts.Content)
                {
                    // Check if the product is in any category
                    var productCategories = _proxy.CategoriesFindForProduct(product.Bvin).Content;

                    // If product is not in any category or not in the selected category, add it to the allProductsListBox
                    if ((productCategories == null || productCategories.Count == 0) && !categoryProductNames.Contains(product.ProductName))
                    {
                        listBoxAllProducts.Items.Add(product.ProductName);
                    }
                }
            }

            if (categoryProducts.Content != null)
            {
                // Add all product names in the selected category to the categoryProductsListBox
                foreach (var product in categoryProducts.Content.Products)
                {
                    listBoxCategoryProducts.Items.Add(product.ProductName);
                }
            }
        }


        private void listBoxAllProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get selected product
            string selectedProductName = listBoxAllProducts.SelectedItem as string;

            if (selectedProductName == null)
            {
                return;
            }

            // Find the product by name
            var product = _proxy.ProductsFindAll().Content?.FirstOrDefault(p => p.ProductName == selectedProductName);

            if (product != null)
            {
                // Create category-product association
                var association = new CategoryProductAssociationDTO { CategoryId = _selectedCategory.Bvin, ProductId = product.Bvin };
                var createResponse = _proxy.CategoryProductAssociationsCreate(association);

                if (createResponse.Errors.Count > 0)
                {
                    MessageBox.Show("There was an error adding the product to the category.");
                    // Log errors as needed...
                }
                else
                {
                    // Update product price
                    decimal discountPercentage = 0;
                    bool isParsed = Decimal.TryParse(_selectedCategory.Description, out discountPercentage);

                    if (isParsed)
                    {
                        product.SitePrice -= product.SitePrice * discountPercentage / 100;
                        var updateResponse = _proxy.ProductsUpdate(product);

                        if (updateResponse.Errors.Count > 0)
                        {
                            MessageBox.Show("There was an error updating the product price.");
                            // Log errors as needed...
                        }
                        else
                        {
                            listBoxCategoryProducts.Items.Add(selectedProductName);
                            listBoxAllProducts.Items.Remove(selectedProductName);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Discount percentage is not properly set for this category.");
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
