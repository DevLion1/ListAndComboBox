using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListAndComboBox
{
    public partial class MainWindow : Window
    {
        // lists for first and last names
        List<string> firstNames = new List<string> { "John", "Jane", "Doe", "Mary", "Bob" };
        List<string> lastNames = new List<string> { "Smith", "Doe", "Johnson", "Taylor", "Brown" };

        public MainWindow()
        {
            InitializeComponent();

            // Setting the ItemsSource for the ComboBox and ListBox
            cmbFirstName.ItemsSource = firstNames;
            lbLastNames.ItemsSource = lastNames;
        }

        private void btnDisplayFullName_Click(object sender, RoutedEventArgs e)
        {
            // Handling null or invalid selection
            if (cmbFirstName.SelectedIndex < 0 || lbLastNames.SelectedIndex < 0) return;

            // Getting the selected names
            string firstName = firstNames[cmbFirstName.SelectedIndex];
            string lastName = lastNames[lbLastNames.SelectedIndex];

            // Displaying the full name
            string fullName = firstName + " " + lastName;
            MessageBox.Show(fullName);
        }

        private void btnAddNames_Click(object sender, RoutedEventArgs e)
        {
            // Adding new names to the lists
            firstNames.Add(txtFirstName.Text);
            lastNames.Add(txtLastName.Text);

            // Refreshing the ComboBox and ListBox to show the new names
            cmbFirstName.Items.Refresh();
            lbLastNames.Items.Refresh();
        }

        private void btnRemoveStudentAtIndex_Click(object sender, RoutedEventArgs e)
        {
            // Handling null or invalid selection
            if (cmbFirstName.SelectedIndex < 0 || lbLastNames.SelectedIndex < 0) return;

            // Removing the selected names
            firstNames.RemoveAt(cmbFirstName.SelectedIndex);
            lastNames.RemoveAt(lbLastNames.SelectedIndex);

            // Refreshing the ComboBox and ListBox
            cmbFirstName.Items.Refresh();
            lbLastNames.Items.Refresh();
        }

        private void lbLastNames_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
           
            cmbFirstName.SelectedIndex = lbLastNames.SelectedIndex;
        }
    }
}