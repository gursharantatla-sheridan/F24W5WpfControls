using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace F24W5WpfControls
{
    /// <summary>
    /// Interaction logic for UserInteractionControlsExamples.xaml
    /// </summary>
    public partial class UserInteractionControlsExamples : Window
    {
        public UserInteractionControlsExamples()
        {
            InitializeComponent();
        }

        private void btnReadCheckboxes_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = "";

            if (chkToronto.IsChecked == true)
                lblOutput.Content += chkToronto.Content + "\n";

            if (chkVancouver.IsChecked == true)
                lblOutput.Content += chkVancouver.Content + "\n";

            if (chkCalgary.IsChecked == true)
                lblOutput.Content += chkCalgary.Content + "\n";
        }

        private void btnReadRadioButtons_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = "";

            if (rdoFemale.IsChecked == true)
                lblOutput.Content = rdoFemale.Content;
            else if (rdoMale.IsChecked == true)
                lblOutput.Content = rdoMale.Content;
            else if (rdoOther.IsChecked == true)
                lblOutput.Content = rdoOther.Content;
            else
                lblOutput.Content = "Please select your gender";
        }

        private void rdoFemale_Checked(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = rdoFemale.Content;
        }

        private void rdoMale_Checked(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = rdoMale.Content;
        }

        private void btnReadCombobox_Click(object sender, RoutedEventArgs e)
        {
            if (cmbCars.SelectedIndex >= 0)
                lblOutput.Content = cmbCars.Text;
            else
                lblOutput.Content = "Please select a car";
        }

        private void cmbCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbCars.SelectedIndex >= 0)
                //lblOutput.Content = cmbCars.Text;
                lblOutput.Content = ((ComboBoxItem)cmbCars.SelectedItem).Content;
            else
                lblOutput.Content = "Please select a car";
        }
    }
}
