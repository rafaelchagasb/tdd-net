using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_net.br.com.rafaelchagasb.notafiscal.dominio;
using tdd_net.br.com.rafaelchagasb.notafiscal.interfaces;
using tdd_net.br.com.rafaelchagasb.notafiscal.services;

namespace tests.br.com.rafaelchagasb.notafiscal.services
{
    [TestFixture]
    public class GeradorNotaFiscalTest
    {
        [Test]
        public void testGerarNotaFiscal()
        {
            //declaração dos mocks
            Mock<ISAPService> mockSap = new Mock<ISAPService>();
            Mock<IEmailService> mockEmail = new Mock<IEmailService>();
            Mock<INFDao> mockNFDao = new Mock<INFDao>();

            //Objeto que será usado como retorno simulado pelo Mock
            NotaFiscal notaFiscalRetorno = new NotaFiscal("Joao da Silva", 100.0, DateTime.Now);

            //passando os mocks para a classe que será testada
            GeradorNotaFiscal geradorNotaFiscal = new GeradorNotaFiscal(mockEmail.Object, mockSap.Object, mockNFDao.Object);

            //============ configurando os comportamentos ===============
            //simulado o método de persistencia e retornando um objeto fake.
            mockNFDao.Setup(m => m.persiste(It.IsAny<NotaFiscal>())).Returns(notaFiscalRetorno);
            mockSap.Setup(m => m.enviar(It.IsAny<NotaFiscal>()));
            mockEmail.Setup(m => m.enviar(It.IsAny<NotaFiscal>()));

            Pedido pedido = new Pedido("Joao da Silva", 100.0);

            NotaFiscal notaFiscal = geradorNotaFiscal.gerarNotaFiscal(pedido);

            Assert.NotNull(notaFiscal);

            Assert.That(notaFiscal.Cliente, Is.EqualTo("Joao da Silva"));

            Assert.That(notaFiscal.Valor, Is.EqualTo(100.0));
        }
    }
}
