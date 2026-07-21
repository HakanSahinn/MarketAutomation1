using Market.BusinessLayer;
using Market.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Forms
{
    public partial class Form1 : Form
    {
        CategoryManager categoryManager = new CategoryManager();
        ProductManager productManager = new ProductManager();

        public Form1()
        {
            InitializeComponent();
        }

        void CategoryList()
        {
            dataGridView1.DataSource = categoryManager.GetAllCategories();
        }

        void ProductList()
        {
            dataGridView2.DataSource = productManager.GetAllProducts();
        }

        void FillCategoriesToComboBox()
        {
            cmb1.DataSource = categoryManager.GetAllCategories();
            cmb1.DisplayMember = "CategoryName";
            cmb1.ValueMember = "CategoryId";      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CategoryList();
            ProductList();
            FillCategoriesToComboBox();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = textBox1.Text; 

            categoryManager.AddCategory(category);
            MessageBox.Show("Kategori başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CategoryList();
            FillCategoriesToComboBox();
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = txtProductName.Text;
            product.ProductPrice = decimal.Parse(txtProductPrice.Text);
            product.ProductStock = int.Parse(txtProductStock.Text);

            // ComboBox'tan seçili olan kategorinin ID'sini alıyoruz
            product.CategoryId = Convert.ToInt32(cmb1.SelectedValue);

            productManager.AddProduct(product);
            MessageBox.Show("Ürün başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ProductList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                int id = int.Parse(dataGridView2.CurrentRow.Cells["ProductId"].Value.ToString());
                productManager.DeleteProduct(id);

                MessageBox.Show("Ürün silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ProductList();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtProductName_TextChanged(object sender, EventArgs e) { }
        private void txtProductPrice_TextChanged(object sender, EventArgs e) { }
        private void txtProductStock_TextChanged(object sender, EventArgs e) { }
        private void cmb1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}