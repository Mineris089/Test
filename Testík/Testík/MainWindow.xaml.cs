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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Testík
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Evidence> evidenceList = new List<Evidence>();

        public MainWindow()
        {
            InitializeComponent();
            evidenceListBox.ItemsSource = evidenceList;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            addNewWin addWindow = new addNewWin();
            addWindow.ShowDialog();
            if (addWindow.DialogResult == true)
            {
                evidenceList.Add(addWindow.NewEvidence);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (evidenceListBox.SelectedItem != null)
            {
                delWin deleteConfirmationWindow = new delWin();
                deleteConfirmationWindow.ShowDialog();
                if (deleteConfirmationWindow.DialogResult == true)
                {
                    evidenceList.Remove((Evidence)evidenceListBox.SelectedItem);
                }
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (evidenceListBox.SelectedItem != null)
            {
                editWin editWindow = new editWin((Evidence)evidenceListBox.SelectedItem);
                editWindow.ShowDialog();
                if (editWindow.DialogResult == true)
                {
                    int index = evidenceListBox.SelectedIndex;
                    evidenceList[index] = editWindow.UpdatedEvidence;
                }
            }
        }

        private void ShowMoreButton_Click(object sender, RoutedEventArgs e)
        {
            if (evidenceListBox.SelectedItem != null)
            {
                showWin showMoreWindow = new showWin((Evidence)evidenceListBox.SelectedItem);
                showMoreWindow.ShowDialog();
            }
        }
    }

}

