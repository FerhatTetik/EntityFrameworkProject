using Egitim301.BusinnesLayer.Abstract;
using Egitim301.BusinnesLayer.Concreate;
using Egitim301.DataAccsessLayer.Abstract;
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
    public partial class FrmCategory: Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EFCategoryDal());
            InitializeComponent();
        }


        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            MessageBox.Show("Category Added");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryID.Text);
            var deleteCategory = _categoryService.TGetById(id);
            _categoryService.TDelete(deleteCategory);
            MessageBox.Show("Category Deleted");
        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryID.Text);
            var category = _categoryService.TGetById(id);
            dataGridView1.DataSource = category;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updateId = int.Parse(txtCategoryID.Text);
            var updatedValue = _categoryService.TGetById(updateId);
            updatedValue.CategoryName = txtCategoryName.Text;
            updatedValue.CategoryStatus = true;
            _categoryService.TUpdate(updatedValue);

        }
    }
}
