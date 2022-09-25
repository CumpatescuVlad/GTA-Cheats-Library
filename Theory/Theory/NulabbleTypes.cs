namespace Basic
{
    internal class NulabbleTypes
    {
        //Nullable types 
        //Generic Struct that allows you to assign null to a data type except string 
        //because string can be null without the nullable class
        //GetValueOrDefault() method is used to get value of a nullable type 
        //Nullable types can get any value from - to + and additonal null
        //Other value are already declared an assigned , those are non-nullable

        Nullable<int> nullNumber = null;
        public static void TestNullable()
        {
            Nullable<int> firstNumber = null;

            //also I can assign null value with a question mark

            int? secondNum = null;
            string text = null;

            Console.WriteLine(firstNumber.GetValueOrDefault());


        }




    }
}
