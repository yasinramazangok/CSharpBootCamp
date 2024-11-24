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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CSharpBootCamp301EFDatabaseEntities cSharpBootCamp301EFDatabaseEntities = new CSharpBootCamp301EFDatabaseEntities();

        private void buttonList_Click(object sender, EventArgs e)
        {         
            var values = cSharpBootCamp301EFDatabaseEntities.Guides.ToList();
            dataGridView1.DataSource = values;  
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();

            guide.Name = textBoxName.Text;
            guide.Surname = textBoxSurname.Text;    

            cSharpBootCamp301EFDatabaseEntities.Guides.Add(guide);
            cSharpBootCamp301EFDatabaseEntities.SaveChanges();

            MessageBox.Show("Rehber başarıyla eklendi!");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            var deletedValue = cSharpBootCamp301EFDatabaseEntities.Guides.Find(id);

            cSharpBootCamp301EFDatabaseEntities.Guides.Remove(deletedValue);
            cSharpBootCamp301EFDatabaseEntities.SaveChanges();

            MessageBox.Show("Rehber silindi!");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            var updatedValue = cSharpBootCamp301EFDatabaseEntities.Guides.Find(id);

            updatedValue.Name = textBoxName.Text;
            updatedValue.Surname = textBoxSurname.Text;

            cSharpBootCamp301EFDatabaseEntities.SaveChanges();

            MessageBox.Show("Rehber başarıyla güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            var values = cSharpBootCamp301EFDatabaseEntities.Guides.Where(g => g.GuideId == id).ToList();
            
            dataGridView1.DataSource = values;
        }
    }
}
