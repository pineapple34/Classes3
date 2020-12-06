using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Classes3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            

            DGbooks.ItemsSource = new List<string> {};
        }

        private void TB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TBfio.Text != "" && TBbookName.Text != "") BtnAdd.IsEnabled = true;
        }
    }
    class Book
    {
        string fio, label, kod, year, pages;

        public Book()
        {
            kod = year = pages = "0";
        }
        public Book(string newFio, string newLabel, string newKod, string newYear, string newPages)
        {
            fio = newFio; label = newLabel; kod = newKod; year = newYear; pages = newPages;
        }
        public void compareBooks()
        {

        }
    }
}
