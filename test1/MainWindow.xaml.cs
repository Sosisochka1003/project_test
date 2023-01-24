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
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore;

namespace test1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PostgresContext db = new PostgresContext();
        public MainWindow()
        {
            InitializeComponent();
            var country = db.countries.ToList();
            var hotel = db.hotels.ToList();
            foreach (var item in country)
            {
                ComboBoxCountry.Items.Add(item.Id);
            }
            foreach (var item in hotel)
            {
                ComboBoxHotel.Items.Add(item.Id);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Country country = new Country { Id = Convert.ToInt32(ComboBoxCountry.SelectedValue)};
            Hotel hotel = new Hotel { Id = Convert.ToInt32(ComboBoxHotel.SelectedValue) };
            Tour temp = new Tour { Name = TextBoxName.Text, Description = TextBoxDescription.Text, Price = Convert.ToInt32(TextBoxPrice.Text), Country = country, Hotel = hotel};
            //MessageBox.Show(ComboBoxCountry.SelectedIndex.ToString());
            db.tours.Add(temp);

            db.SaveChanges();
        }
    }
}
