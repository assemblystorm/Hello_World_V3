using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//----------------------------//
//           Message          //
//----------------------------//
//       -_text: String       //
//----------------------------//
//   + Message(string txt)    //
//          + Pring()         //
//----------------------------//

namespace HelloWorld_V3
{
    //Name of the class
    internal class Message  
    {
        //instances: stuff the object knows
        private string _text;

        //methods
        public Message(string text) //constructor
        {
            _text = text;
        }

        public void Print()
        {
            Console.WriteLine(_text);
        }
    }
}
