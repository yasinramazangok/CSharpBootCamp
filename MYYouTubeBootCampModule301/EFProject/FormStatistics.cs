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
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        CSharpBootCamp301EFDatabaseEntities cSharpBootCamp301EFDatabaseEntities = new CSharpBootCamp301EFDatabaseEntities();

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            #region Total Location Count

            labelLocationCount.Text = cSharpBootCamp301EFDatabaseEntities.Locations.Count().ToString();

            CenterLabelInPanel(labelLocationCount, panel1);

            #endregion

            #region Sum Capacity

            labelSumCapacity.Text = cSharpBootCamp301EFDatabaseEntities.Locations.Sum(c => c.Capacity).ToString();

            CenterLabelInPanel(labelSumCapacity, panel2);

            #endregion 

            #region Average Capacity

            labelAverageCapacity.Text = cSharpBootCamp301EFDatabaseEntities.Locations.Average(c => (byte?)c.Capacity).GetValueOrDefault().ToString("F2");

            CenterLabelInPanel(labelAverageCapacity, panel4);

            #endregion

            #region Total Guide Count

            labelTotalGuide.Text = cSharpBootCamp301EFDatabaseEntities.Guides.Count().ToString();

            CenterLabelInPanel(labelTotalGuide, panel3);

            #endregion

            #region Average Tour Price

            //labelAverageTourPrice.Text = cSharpBootCamp301EFDatabaseEntities.Locations.Average(p => p.Price).ToString("F2") + " ₺";

            labelAverageTourPrice.Text = cSharpBootCamp301EFDatabaseEntities.Locations
    .Average(p => (decimal?)p.Price).GetValueOrDefault().ToString("F2") + " ₺";


            CenterLabelInPanel(labelAverageTourPrice, panel8);

            #endregion

            #region Last Added Country

            int lastAddedCountryId = cSharpBootCamp301EFDatabaseEntities.Locations.Max(c => c.LocationId);
            labelLastAddedCountry.Text = cSharpBootCamp301EFDatabaseEntities.Locations.Where(c => c.LocationId == lastAddedCountryId).Select(c => c.Country).FirstOrDefault();

            CenterLabelInPanel(labelLastAddedCountry, panel7);

            #endregion

            #region Hatay Tour Capacity

            labelHatayTourCapacity.Text = cSharpBootCamp301EFDatabaseEntities.Locations.Where(c => c.City == "Hatay").Select(c => c.Capacity).FirstOrDefault().ToString();

            CenterLabelInPanel(labelHatayTourCapacity, panel5);

            #endregion

            #region Turkey Tours Average Capacity

            labelTurkeyToursAverageCapacity.Text = cSharpBootCamp301EFDatabaseEntities.Locations.Where(c => c.Country == "Türkiye").Average(c => (byte?)c.Capacity).GetValueOrDefault().ToString("F2");

            CenterLabelInPanel(labelTurkeyToursAverageCapacity, panel6);

            #endregion

            #region Milano Tour Guide

            var milanoGuideId = cSharpBootCamp301EFDatabaseEntities.Locations.Where(c => c.City == "Milano").Select(y => y.GuideId).FirstOrDefault();
            labelMilanoTourGuide.Text = cSharpBootCamp301EFDatabaseEntities.Guides.Where(g => g.GuideId == milanoGuideId).Select(n => n.Name + " " + n.Surname).FirstOrDefault().ToString();

            CenterLabelInPanel(labelMilanoTourGuide, panel12);

            #endregion

            #region Highest Capacity Tour

            var highestCapacityTour = cSharpBootCamp301EFDatabaseEntities.Locations.Max(c => c.Capacity);
            labelHighestCapacityTour.Text = cSharpBootCamp301EFDatabaseEntities.Locations.Where(c => c.Capacity == highestCapacityTour).Select(c => c.City).FirstOrDefault().ToString();

            CenterLabelInPanel(labelHighestCapacityTour, panel11);

            #endregion

            #region Most Expensive Tour

            var mostExpensiveTour = cSharpBootCamp301EFDatabaseEntities.Locations.Max(p => p.Price);
            labelMostExpensiveTour.Text = cSharpBootCamp301EFDatabaseEntities.Locations.Where(p => p.Price == mostExpensiveTour).Select(c => c.City).FirstOrDefault().ToString();

            CenterLabelInPanel(labelMostExpensiveTour, panel9);

            #endregion

            #region Mehmet Ali GOK Tour Count

            var guideIdByNameMehmetAliGOK = cSharpBootCamp301EFDatabaseEntities.Guides.Where(n => n.Name == "Mehmet Ali" && n.Surname == "GÖK").Select(g => g.GuideId).FirstOrDefault();
            labelMehmetAliGOKTourCount.Text = cSharpBootCamp301EFDatabaseEntities.Locations.Where(g => g.GuideId == guideIdByNameMehmetAliGOK).Count().ToString();

            CenterLabelInPanel(labelMehmetAliGOKTourCount, panel10);

            #endregion
        }

        private void CenterLabelInPanel(Label label, Panel panel)
        {
            int panelWidth = panel.Width;
            int panelHeight = panel.Height;

            int labelWidth = label.Width;
            int labelHeight = label.Height;

            label.Left = (panelWidth - labelWidth) / 2;
            label.Top = (panelHeight - labelHeight) / 2;
        }
    }
}
