namespace CalcUL.BinaryOperations
{
   public class Adder:IBinaryOperation
    {
       public string Calc(double first, double second)
       {
           double result = first + second;

           return result.ToString();
       }
    }
}
