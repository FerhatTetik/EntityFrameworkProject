using Egitim301.BusinnesLayer.Abstract;
using Egitim301.BusinnesLayer.Concreate;
using Egitim301.DataAccsessLayer.EntityFramework;
using Egitim301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egitim301.PresentationLayer
{
    public partial class FrmProduct: Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EFProductDal());
            _categoryService = new CategoryManager(new EFCategoryDal());
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.GetProductListWithCategoryName();
            dataGridView1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtProductID.Text);
            var product = _productService.TGetById(id);
            _productService.TDelete(product);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtProductID.Text);
            var product = _productService.TGetById(id);
            product.ProductName = txtProductName.Text;
            product.ProductStock = Convert.ToInt32(txtProductStock.Text);
            product.ProductPrice = Convert.ToDecimal(txtProductPrice.Text);
            product.ProductDescription = txtDesc.Text;
            product.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            _productService.TUpdate(product);
        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtProductID.Text);
            var product = _productService.TGetById(id);
            dataGridView1.DataSource = product;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product(); 
            product.ProductName = txtProductName.Text;
            product.ProductStock = Convert.ToInt32(txtProductStock.Text);
            product.ProductPrice = Convert.ToDecimal(txtProductPrice.Text);
            product.ProductDescription = txtDesc.Text;
            product.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            _productService.TInsert(product);
            MessageBox.Show("Product Eklendi.");
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _categoryService.TGetAll();
            cmbCategory.DataSource = values;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.SelectedIndex = -1;
        }
    }
}
