using Egitim301.BusinnesLayer.Concreate;
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
    public partial class FrmProduct: Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }
        ProductManager productManager = new ProductManager(new EFProductDal());

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = productManager.TGetAll();
            dataGridView1.DataSource = values;
        }
    }
}
