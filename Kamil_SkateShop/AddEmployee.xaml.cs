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
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            AppCompute appcomp = new AppCompute();

            string[] strinput = new string[3];
            int nbrinput = 0;

            strinput[0] = EMPID.Text;
            strinput[1] = JobTitle.Text;
            strinput[2] = Salary.Text;
            


            nbrinput = 3;

            retval = appcomp.showData(strinput, nbrinput);
        }
    }
}
