    
using FewBox.Service.Demo.Controllers;
using FewBox.Service.Demo.Model.Dtos;
using FewBox.Service.Demo.Model.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FewBox.Service.Demo.TestSuite
{
    [TestClass]
    public class FewBoxControllerUnitTest
    {
        private FewBoxController FewBoxController { get; set; }

        [TestInitialize]
        public void Init()
        {
            // E.G: l.Method(It.IsAny<string>());
            var fewboxService = Mock.Of<IFewBoxService>(l=>
                l.GetAuthor()== new AuthorDto { Name = "1.0.1" });
            this.FewBoxController = new FewBoxController(fewboxService);
        }


        [TestMethod]
        public void TestGet()
        {
            var response = this.FewBoxController.Get();
            Assert.AreEqual("1.0.1", response.Payload.Name);
        }
    }
}