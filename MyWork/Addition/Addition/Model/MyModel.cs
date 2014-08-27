using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AddLogic;
namespace Addition.Model
{
    public class MyModel
    {

        public IAddLogic _addLogic;

        public MyModel(IAddLogic addLogic)
        {
            _addLogic = addLogic;
        }
    }
}