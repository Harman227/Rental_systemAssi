using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rental_systemAss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_systemAss.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            adminMain obj = new adminMain();

            String query = "insert into Customer(Name,Contact,Address)values('test','test','test')";
            obj.CmdQuery(query);
            Assert.IsTrue(true);
        }
    }
}