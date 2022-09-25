namespace Intermediatte
{
    public class Delegates
    {

        //Delegates are used to safley encapsulate a method
        //Delegates cand be passed to methods as parameters 
        //if you pass that delegate as parameter you implicitly pass the method as parameter
        //You can create custom delegates, or use pre defined like Func<T,TResult> and Action<T>

        public static void Execute()
        {
            Calculator addition = Addition;
            Calculator subtraction = Substraction;

            Operation(subtraction, 45, 20);
        }


        public delegate int Calculator(int num, int secondNum);

        public static int Addition(int num, int secondNum)
        {

            return num + secondNum;
        }

        public static int Substraction(int num, int secondNum)
        {

            return num - secondNum;
        }

        public static void Operation(Calculator calc, int num, int secondNum)
        {
            Console.WriteLine(calc(num, secondNum));
        }




    }
}
