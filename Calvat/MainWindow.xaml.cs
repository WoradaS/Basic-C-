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

namespace StaticTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double price = double.Parse(PriceTextBox.Text);
            double vat = double.Parse(VatTextBox.Text);

            double totalprice = VatCal.TotalPrice(price, vat);
            double vatprice = VatCal.VatPrice(price, vat);

            MessageBox.Show("ราคาสินค้า: " + price + " บาท ภาษี: " + vat + "% \n"
                + "ภาษีมูลค่าเพิ่ม: " + vatprice + " บาท ราคาทั้งหมด: " + totalprice + " บาท");
        }

        
    }
}
