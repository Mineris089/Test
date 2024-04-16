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
    /// Interakční logika pro delWin.xaml
    /// </summary>
    public partial class delWin : Window
    {
        public delWin()
        {
            InitializeComponent();
        }

        private void AnoButton_Click(object sender, RoutedEventArgs e)
        {
           
            DialogResult = true;
        }

        private void NeButton_Click(object sender, RoutedEventArgs e)
        {
           
            DialogResult = false;
        }
    }
}
