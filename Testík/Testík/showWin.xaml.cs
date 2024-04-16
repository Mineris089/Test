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
    /// Interakční logika pro showWin.xaml
    /// </summary>
    public partial class showWin : Window
    {
        public showWin(Evidence evidence)
        {
            InitializeComponent();
            // Display all the details of the provided Evidence object
            DataContext = $"ID: {evidence.ID}\n" +
                          $"First Name: {evidence.Jmeno}\n" +
                          $"Last Name: {evidence.Prijmeni}\n" +
                          $"Date of Birth: {evidence.DatumNarozeni}";
        }
    }
}
