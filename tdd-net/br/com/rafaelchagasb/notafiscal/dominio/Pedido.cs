using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_net.br.com.rafaelchagasb.notafiscal.dominio
{
    public class Pedido
    {
        public string Cliente { get; set; }

        public double Valor { get; set; }

        public Pedido(string _cliente, double _valor)
        {
            Cliente = _cliente;
            Valor = _valor;
        }
    }
}