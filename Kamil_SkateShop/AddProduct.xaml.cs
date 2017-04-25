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
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        public AddProduct()
        {
            InitializeComponent();
        }
      

        private void save_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            AppCompute appcomp = new AppCompute();

            string[] strinput = new string[5];
            int nbrinput = 0;

            strinput[0] = txtProductID.Text;
            strinput[1] = txtName.Text;
            strinput[2] = txtPrice.Text;
            strinput[3] = txtBrandID.Text;
            strinput[4] = txtOnHand1.Text;


            nbrinput = 5;

            retval = appcomp.showData(strinput, nbrinput);
        }
    }
}
