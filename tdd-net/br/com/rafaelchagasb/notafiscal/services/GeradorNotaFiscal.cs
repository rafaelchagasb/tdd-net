using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_net.br.com.rafaelchagasb.notafiscal.dominio;
using tdd_net.br.com.rafaelchagasb.notafiscal.interfaces;

namespace tdd_net.br.com.rafaelchagasb.notafiscal.services
{
    public class GeradorNotaFiscal
    {
        IEmailService emailService;

        ISAPService sapService;

        INFDao nfdao;

        public GeradorNotaFiscal()
        {
        }

        public GeradorNotaFiscal(IEmailService emailService, ISAPService sapService, INFDao nfdao)
        {
            this.emailService = emailService;
            this.sapService = sapService;
            this.nfdao = nfdao;
        }

        public NotaFiscal gerarNotaFiscal(Pedido pedido)
        {

            NotaFiscal notaFiscal = new NotaFiscal(pedido.Cliente, pedido.Valor, DateTime.Now);

            notaFiscal = nfdao.persiste(notaFiscal);

            emailService.enviar(notaFiscal);

            sapService.enviar(notaFiscal);

            return notaFiscal;

        }
    }
}
