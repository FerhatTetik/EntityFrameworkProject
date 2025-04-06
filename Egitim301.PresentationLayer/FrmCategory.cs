using Egitim301.BusinnesLayer.Abstract;
using Egitim301.BusinnesLayer.Concreate;
using Egitim301.DataAccsessLayer.Abstract;
using Egitim301.DataAccsessLayer.EntityFramework;
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
    }
}
