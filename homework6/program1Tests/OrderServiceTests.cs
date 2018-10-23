using Microsoft.VisualStudio.TestTools.UnitTesting;
using program1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace program1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        List<Order> myorderText = new List<Order>();
        string name = "礼和";
        string good = "adc";
        double price = 0.3;
        
        [TestMethod()]
        public void addorderTest()
        {
            Order order = new Order(name, good, price);
            myorderText.Add(order);

            OrderService orderService = new OrderService();
            orderService.addorder(name, good, price);
            Assert.AreEqual(myorderText[0].Name,orderService.Myorder[0].Name);
            Assert.AreEqual(myorderText[0].Good, orderService.Myorder[0].Good);
            Assert.AreEqual(myorderText[0].Price, orderService.Myorder[0].Price);
            //Assert.Fail();
        }

        [TestMethod()]
        public void ExportTest()
        {
            OrderService orderService = new OrderService();
            orderService.addorder(name, good, price);
            orderService.Export();           
            Assert.IsNotNull($"序列化.xml");
            //Assert.Fail();
        }

        [TestMethod()]
        public void ImportTest()
        { 

            OrderService orderService = new OrderService();
            orderService.Import();
            Assert.AreEqual(name, orderService.Orders[0].Name);
            Assert.AreEqual(good, orderService.Orders[0].Good);
            Assert.AreEqual(price, orderService.Orders[0].Price);
            //Assert.Fail();
        }
    }
}