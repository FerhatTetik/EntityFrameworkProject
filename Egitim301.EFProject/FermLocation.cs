using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egitim301.EFProject
{
    public partial class FermLocation: Form
    {
        public FermLocation()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();


        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location
                .Select(x => new
                {
                    x.LocationId,
                    x.City,
                    x.Country,
                    x.Capasity,
                    x.Price,
                    x.DayNight,
                    GuideName = x.Guide.GuideName + " " + x.Guide.GuideSurname // Rehber adını string olarak çekiyoruz
                })
                .ToList();

            dataGridView1.DataSource = values;
        }


        private void FermLocation_Load(object sender, EventArgs e)
        {
            var guides = db.Guide.Select(x => new
            {
                FullName = x.GuideName+x.GuideSurname,
                x.GuideId
            }).ToList();
            cmbGuide.DisplayMember = "FullNAme";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = guides;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtCity.Text) || string.IsNullOrWhiteSpace(txtCountry.Text))
            {
                MessageBox.Show("Şehir ve ülke bilgileri boş olamaz!");
                return;
            }

            if (!byte.TryParse(nudCapasity.Value.ToString(), out byte capacity))
            {
                MessageBox.Show("Kapasite hatalı!");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Fiyat geçerli bir sayı değil!");
                return;
            }

            if (cmbGuide.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir rehber seçin!");
                return;
            }

            try
            {
                Location location = new Location
                {
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Capasity = capacity,
                    Price = price,
                    DayNight = txtDayNight.Text,
                    GuideId = Convert.ToInt32(cmbGuide.SelectedValue)
                };

                db.Location.Add(location);
                db.SaveChanges();
                MessageBox.Show("Ekleme Başarılı");
                btnList_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme sırasında hata oluştu: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedValues = db.Location.Find(id);
            db.Location.Remove(deletedValues);
            db.SaveChanges();
            MessageBox.Show("Başarıla silindi.");
            btnList_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatedValues = db.Location.Find(id);
            updatedValues.DayNight = txtDayNight.Text;
            updatedValues.GuideId = Convert.ToInt32(cmbGuide.SelectedValue);
            updatedValues.Capasity=byte.Parse(nudCapasity.Value.ToString());
            updatedValues.City=txtCity.Text;
            updatedValues.Country=txtCountry.Text;
            updatedValues.Price=decimal.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı.");
            btnList_Click(sender, e);
            
        }
    }
}

