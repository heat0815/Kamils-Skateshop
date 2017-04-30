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

namespace Kamil_SkateShop
{
    /// <summary>
    /// Interaction logic for AddVendor.xaml
    /// </summary>
    public partial class AddVendor : Window
    {
        public AddVendor()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            AppCompute appcomp = new AppCompute();

            string[] strinput = new string[5];
            int nbrinput = 0;

            strinput[0] = VendID.Text;
            strinput[1] = Comp.Text;
            strinput[2] = contact.Text;
            strinput[3] = email.Text;
            strinput[4] = phone.Text;



            nbrinput = 5;

            retval = appcomp.showData(strinput, nbrinput);
        }
    }
}
