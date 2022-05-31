using BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Services
{
    public class ReverserDisplay : IDisplayFormatter
    {
        public void Display(string text)
        {
            Console.WriteLine("Reversed: " + new string(text.Reverse().ToArray()));
        }
    }
}
