using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4.Tests
{
    [TestClass()]
    public class UtilTests
    {
        private TextBox textboxask;
        private Label labelplusnimus;
        [TestMethod()]

        public void NumberTest()
        {
            try
            {
                Util tests = new Util();
                tests.Number("2", textboxask, labelplusnimus);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void formloadTest()
        {
            try
            {
                Util tests = new Util();
                tests.formload(textboxask, labelplusnimus);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void SignTest()
        {
            try
            {
                Util tests = new Util();
                tests.Sign("+", textboxask, labelplusnimus);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void AskTest()
        {
            try
            {
                Util tests = new Util();
                tests.Ask(textboxask, labelplusnimus);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void NumTest()
        {
            try
            {
                Util tests = new Util();
                textboxask.Text = "12";
                tests.Num(textboxask);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void AskmetTest()
        {
            try
            {
                Util tests = new Util();
                tests.Askmet(textboxask);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void CalculateTest()
        {
            try
            {
                Util tests = new Util();
                tests.Calculate(textboxask, labelplusnimus);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void PlusMinusTest()
        {
            try
            {
                Util tests = new Util();
                tests.PlusMinus(labelplusnimus, textboxask);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }
    }
}