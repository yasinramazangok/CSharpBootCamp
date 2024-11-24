using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFProject
{
    public partial class FormLocation : Form
    {
        public FormLocation()
        {
            InitializeComponent();
        }

        CSharpBootCamp301EFDatabaseEntities cSharpBootCamp301EFDatabaseEntities = new CSharpBootCamp301EFDatabaseEntities();

        private void FormLocation_Load(object sender, EventArgs e)
        {
            /*
            var values = cSharpBootCamp301EFDatabaseEntities.Guides.ToList();

            comboBoxGuide.DisplayMember = "Name";
            comboBoxGuide.ValueMember = "GuideId";
            comboBoxGuide.DataSource = values;
            */

            var values = cSharpBootCamp301EFDatabaseEntities.Guides.Select(g => new
            {
                FullName = g.Name + " " + g.Surname,
                g.GuideId
            }).ToList();

            comboBoxGuide.DisplayMember = "FullName";
            comboBoxGuide.ValueMember = "GuideId";
            comboBoxGuide.DataSource = values;
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            var values = cSharpBootCamp301EFDatabaseEntities.Locations.ToList();
            dataGridView1.DataSource = values;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity = byte.Parse(numericUpDownCapacity.Value.ToString());
            location.City = textBoxCity.Text;
            location.Country = textBoxCountry.Text;
            location.Price = decimal.Parse(textBoxPrice.Text);
            location.DayNight = textBoxDayNight.Text;
            location.GuideId = int.Parse(comboBoxGuide.SelectedValue.ToString());

            cSharpBootCamp301EFDatabaseEntities.Locations.Add(location);
            cSharpBootCamp301EFDatabaseEntities.SaveChanges();

            MessageBox.Show("Lokasyon başarıyla eklendi!");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            var deletedValue = cSharpBootCamp301EFDatabaseEntities.Locations.Find(id);

            cSharpBootCamp301EFDatabaseEntities.Locations.Remove(deletedValue);
            cSharpBootCamp301EFDatabaseEntities.SaveChanges();

            MessageBox.Show("Silme işlemi başarılı!");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            var updatedValue = cSharpBootCamp301EFDatabaseEntities.Locations.Find(id);

            updatedValue.Capacity = byte.Parse(numericUpDownCapacity.Value.ToString());
            updatedValue.City = textBoxCity.Text;
            updatedValue.Country = textBoxCountry.Text;
            updatedValue.Price = decimal.Parse(textBoxPrice.Text);
            updatedValue.DayNight = textBoxDayNight.Text;
            updatedValue.GuideId = int.Parse(comboBoxGuide.SelectedValue.ToString());

            cSharpBootCamp301EFDatabaseEntities.SaveChanges();

            MessageBox.Show("Lokasyon başarıyla güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
