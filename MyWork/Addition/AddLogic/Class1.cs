using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddLogic
{
    public class Class1:IAddLogic
    {

        public IEnumerable<string> NumCollection
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Class1()
        {
            NumCollection = new List<string> { "1","One"};
        }
    }

    public interface IAddLogic
    {
       IEnumerable<string> NumCollection { get; set; }
    }

}
