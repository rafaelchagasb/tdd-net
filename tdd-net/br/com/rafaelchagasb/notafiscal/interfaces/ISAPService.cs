using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_net.br.com.rafaelchagasb.notafiscal.dominio;

namespace tdd_net.br.com.rafaelchagasb.notafiscal.interfaces
{
    public interface ISAPService
    {
        void enviar(NotaFiscal nota);
    }
}
