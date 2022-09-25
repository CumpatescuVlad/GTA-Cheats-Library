namespace Basic
{
    public class TypesAndVariables
    {
        //Value Types
        //Value types are variables that hold the data, hold a value

        int firstNumber = 5;

        string myText = "Some Text";

        bool isRunning = true;

        //Reffrence types(object)
        //reffrence types hold a reffrence to a varible , for example 
        //an object of a class, hold a reffrence to a method

        TypesAndVariables reffrence = new TypesAndVariables();



        public static void Method(string[] args)
        {
            TypesAndVariables reffrence = new TypesAndVariables();

            reffrence.ReturnSentance();


        }
        public string ReturnSentance()
        {


            return myText;
        }
    }
}
