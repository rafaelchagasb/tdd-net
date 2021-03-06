﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_net.br.com.rafaelchagasb.notafiscal.dominio
{
    public class NotaFiscal
    {
        public string Cliente { get; set; }

        public double Valor { get; set; }

        public DateTime Data { get; set; }

        public NotaFiscal(string _cliente, double _valor, DateTime _data)
        {
            Cliente = _cliente;
            Valor = _valor;
            Data = _data;
        }
    }
}
