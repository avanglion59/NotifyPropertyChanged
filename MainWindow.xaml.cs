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

namespace NotifyPropertyChanged
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        ObservableCollection<Phone> phones;
        public MainWindow()
        {
            InitializeComponent();
            phones = new ObservableCollection<Phone>()
            {
                new Phone()
                {
                    Title = "IPhone 6",
                    Company = "Apple",
                    Price = 6000
                },
                new Phone()
                {
                    Title = "IPhone 7",
                    Company = "Apple",
                    Price = 8000
                },
                new Phone()
                {
                    Title = "Nexus 5",
                    Company = "Google",
                    Price = 7000
                },
            };
            dataGrid.ItemsSource = phones;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            phones[0].Company = "Google";
        }
    }
}
