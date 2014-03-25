using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcUL.BinaryOperations
{
    public static class BinaryOperationsFactory
    {
        public static IBinaryOperation CreateOperation(string name)
        {
            switch (name)
            {
                case "Addition": 
                    return new Adder();
                case "Division":
                    return new Divider();
                case "Substraction":
                    return new Substracter();
                case "Multiplication":
                    return new Multiplicater();
                default: 
                    throw new ArgumentException("Unknow argyment", "name");
            }
        }
    }
}
