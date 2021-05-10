using System;
using System.Linq;

namespace Core
{
    public class CheckString    {
        public string Value { get; set; }
        public CheckString(string value)
        {
            Value = value; 
        }

        public bool CheckPalindromeString()
        {            
            return Value.SequenceEqual(Value.Reverse());
        } 

        
    }
}
