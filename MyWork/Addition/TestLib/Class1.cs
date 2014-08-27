using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AddLogic;
using Addition.Model;
using Rhino.Mocks;
using NUnit.Framework;

namespace TestLib
{
    [TestFixture]
    public class Class1
    {

        [Test]
        public void MyTest()
        {
            var addMock = MockRepository.GenerateStub<IAddLogic>();

            var model = new MyModel(addMock);

            Assert.AreSame(addMock, model._addLogic);
        }
    }
}
