using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_net.br.com.rafaelchagasb.utils
{
    public class CalculoAnoBixSextoUtil
    {
        public bool EhBixSexto(int ano)
        {
            if (ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0))
            {
                return true;
            }

            return false;
        }
    }
}
