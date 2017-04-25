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
    /// Interaction logic for AddInventory.xaml
    /// </summary>
    public partial class AddInventory : Window
    {
        public AddInventory()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            AppCompute appcomp = new AppCompute();

            string[] strinput = new string[4];
            int nbrinput = 0;

            strinput[0] = itemID.Text;
            strinput[1] = ONHand.Text;
            strinput[2] = Descr.Text;
            strinput[3] = cost.Text;
           


            nbrinput = 4;

            retval = appcomp.showData(strinput, nbrinput);
        }
    }
}
