using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1.clases
{
        public class ClaseSuma
    {
        public static Double Eval(String expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));



        }

        
        
    }
}
