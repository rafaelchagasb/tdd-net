using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using tdd_net.br.com.rafaelchagasb.utils;

namespace tests.br.com.rafaelchagasb.utils
{
    [TestFixture]
    public class CalculoAnoBixSextoUtilTest
    {
        [Test]
        public void testAnoMultiploDe400()
        {
            Assert.That(new CalculoAnoBixSextoUtil().EhBixSexto(1600), Is.EqualTo(true));
            Assert.IsTrue(new CalculoAnoBixSextoUtil().EhBixSexto(2000));
            Assert.IsTrue(new CalculoAnoBixSextoUtil().EhBixSexto(2400));
            Assert.IsTrue(new CalculoAnoBixSextoUtil().EhBixSexto(2800));
        }

        [Test]
        public void testAnoMultiplo100_NaoEhBixSexto()
        {
            Assert.IsFalse(new CalculoAnoBixSextoUtil().EhBixSexto(1900));
            Assert.IsFalse(new CalculoAnoBixSextoUtil().EhBixSexto(2200));
            Assert.IsFalse(new CalculoAnoBixSextoUtil().EhBixSexto(1700));
        }

        [Test]
        public void testAnoMultiploDe4()
        {
            Assert.IsTrue(new CalculoAnoBixSextoUtil().EhBixSexto(1996));
            Assert.IsTrue(new CalculoAnoBixSextoUtil().EhBixSexto(2000));
            Assert.IsTrue(new CalculoAnoBixSextoUtil().EhBixSexto(2004));
            Assert.IsTrue(new CalculoAnoBixSextoUtil().EhBixSexto(2008));
            Assert.IsTrue(new CalculoAnoBixSextoUtil().EhBixSexto(2012));
            Assert.IsTrue(new CalculoAnoBixSextoUtil().EhBixSexto(2016));
        }

        [Test]
        public void testAnosNaoBixSextos()
        {
            Assert.IsFalse(new CalculoAnoBixSextoUtil().EhBixSexto(1001));
            Assert.IsFalse(new CalculoAnoBixSextoUtil().EhBixSexto(1971));
            Assert.IsFalse(new CalculoAnoBixSextoUtil().EhBixSexto(1979));
            Assert.IsFalse(new CalculoAnoBixSextoUtil().EhBixSexto(2013));
        }
    }
}
