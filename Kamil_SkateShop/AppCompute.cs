using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Kamil_SkateShop
{
    class AppCompute
    {
        public int showData(string[] strargs, int intargs)
        {

            string msgtxt = " ";

            for (int i = 0; i <= strargs.GetUpperBound(0); i++)
            { msgtxt = msgtxt + " " + strargs[i].ToString() + "\n"; };

            MessageBox.Show(msgtxt);
            return 0;
        }

    }
}
