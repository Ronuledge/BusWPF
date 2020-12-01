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

namespace BusWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bus[] bus = new Bus[4];
        public MainWindow()
        {

            InitializeComponent();
            for (int i = 0; i <= 3; i++)
            {
                bus[i] = new Bus();
            }
            bus[0].nameDriver = "Максим";
            bus[1].nameDriver = "Иван";
            bus[2].nameDriver = "Марат";
            bus[3].nameDriver = "Никита";
            bus[0].inicialiDriver = "Г. Д";
            bus[1].inicialiDriver = "М. В";
            bus[2].inicialiDriver = "С. Т.";
            bus[3].inicialiDriver = "А. Б.";
            bus[0].numberBus = 2;
            bus[1].numberBus = 11;
            bus[2].numberBus = 19;
            bus[3].numberBus = 16;
            bus[0].numberMarshrut = 2;
            bus[1].numberMarshrut = 3;
            bus[2].numberMarshrut = 2;
            bus[3].numberMarshrut = 4;
            bus[0].markaBus = "Лексус";
            bus[1].markaBus = "Кадиллак";
            bus[2].markaBus = "Ягуар";
            bus[3].markaBus = "Бугатти";
            bus[0].busYear = 2;
            bus[1].busYear = 1;
            bus[2].busYear = 5;
            bus[3].busYear = 7;
            bus[0].busProbeg = 60000;
            bus[1].busProbeg = 15000;
            bus[2].busProbeg = 5000;
            bus[3].busProbeg = 53000;
        }
        public void ListBox_Clear()
        {
            listBoxBus.Items.Clear();
        }

        private void btnNumMarshrut_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ListBox_Clear();
                for (int i = 0; i <= 3; i++)
                {
                    if (bus[i].numberMarshrut == Convert.ToInt32(txtNumMarshrut.Text))
                    {
                        listBoxBus.Items.Add(bus[i].nameDriver + " "
                            + bus[i].inicialiDriver + " " + bus[i].markaBus + " "
                            + bus[i].busYear + " " + bus[i].numberMarshrut + " "
                            + bus[i].numberBus + " " + bus[i].busProbeg);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных", "Ошибка", MessageBoxButton.OK);
            }
        }

        private void btnBusYear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ListBox_Clear();
                for (int i = 0; i <= 3; i++)
                {
                    if (bus[i].busYear > Convert.ToInt32(txtBusYear.Text))
                    {
                        listBoxBus.Items.Add(bus[i].nameDriver + " "
                            + bus[i].inicialiDriver + " " + bus[i].markaBus + " "
                            + bus[i].busYear + " " + bus[i].numberMarshrut + " "
                            + bus[i].numberBus + " " + bus[i].busProbeg);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных", "Ошибка", MessageBoxButton.OK);
            }
        }

        private void BusProbeg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ListBox_Clear();
                for (int i = 0; i <= 3; i++)
                {
                    if (bus[i].busProbeg > Convert.ToInt32(txtBusProbeg.Text))
                    {
                        listBoxBus.Items.Add(bus[i].nameDriver + " "
                            + bus[i].inicialiDriver + " " + bus[i].markaBus + " "
                            + bus[i].busYear + " " + bus[i].numberMarshrut + " "
                            + bus[i].numberBus + " " + bus[i].busProbeg);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных", "Ошибка", MessageBoxButton.OK);
            }
        }
    }
}
