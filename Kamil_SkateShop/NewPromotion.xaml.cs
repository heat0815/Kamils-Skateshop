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
    /// Interaction logic for NewPromotion.xaml
    /// </summary>
    public partial class NewPromotion : Window
    {
        public NewPromotion()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            AppCompute appcomp = new AppCompute();

            string[] strinput = new string[6];
            int nbrinput = 0;
            strinput[0] = txtPromotionID.Text;
            strinput[1] = txtPromoTitle.Text;
            strinput[2] = txtPromoDesc.Text;
            strinput[3] = txtPromoStart.Text;
            strinput[4] = txtPromoEnd.Text;
            strinput[5] = txtPromoCreated.Text;

            nbrinput = 6;

            retval = appcomp.showData(strinput, nbrinput);
        }
    }
}
