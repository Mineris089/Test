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

namespace Testík
{
    /// <summary>
    /// Interakční logika pro editWin.xaml
    /// </summary>
    public partial class editWin : Window
    {
        public Evidence UpdatedEvidence { get; private set; }

        public editWin(Evidence evidence)
        {
            InitializeComponent();
            
            DataContext = evidence;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
        
                UpdatedEvidence = new Evidence
                {
                    Jmeno = jmenoTextBox.Text,
                    Prijmeni = prijmeniTextBox.Text,
                    ID = int.Parse(idTextBox.Text),
                    DatumNarozeni = datePicker.SelectedDate ?? DateTime.MinValue
                };
               
                DialogResult = true;
      
        }
    }
}
