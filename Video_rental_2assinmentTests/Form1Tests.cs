using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_rental_2assinment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_rental_2assinment.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            DataForwarding dataForwarding = new DataForwarding();
            dataForwarding.CmdQuery("insert into RentalDetails values(1,1,'02/02/2021','given')");
            Assert.IsTrue(true);
        }
    }
}