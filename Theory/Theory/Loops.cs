namespace Basic
{
    public class Loops
    {
        //loops allow you to iterate trough diffrent sections of code
        //for loop , iterates trough code each time of the specified condition
        //while loop 
        //Foreach is a specia loop that allows you to loop trugh collections 
        //it implmenets Ienumerable<T> and IEnumerable<T>

        public void Loop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("DOGGG");
                //Dogg appears 10 times
            }
            int number = 3;

            while (number > 0)
            {
                Console.WriteLine("This number is greather than 0");

                break;
            }

            do
            {
                Console.WriteLine("Do is executed");
                break;
            }
            while (number > 0);
            {
                Console.WriteLine("While is executed now ");
                return;
            }



        }
        //Diffrence between break and continue



        public void BreakVSContinue()
        {
            string[] names = { "ANGELO", "MARY", "JOHN", "DERRY" };

            foreach (var name in names)
            {
                if (name.Equals("JOHN")) continue;

                if (name.Equals("ANGELO")) break;

                Console.WriteLine(name);
            }

        }


    }
}
