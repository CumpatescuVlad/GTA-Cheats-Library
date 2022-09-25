namespace Intermediatte
{
    internal class LambdaDelegate
    {
        //Wtih lambda you don`t need to create separate methods 
        //You create them direcly at the object declaration
        //Lambda expression is best used with Action<T> and Func<T,TResult>

        public static void Execute()
        {
            //insetead of writing all of this

            Action personName = PersonName;
            Action personAge = PersonAge;

            //Person(personName);
            //Person(personAge);
            //You can do the following
            //Action delegate encapsulates methods that return value is void
            //you are not needed to create an custom delegate

            Action<string> nameOfThePerson = (string name) => { Console.WriteLine($"My name is{name}"); };

            Person(nameOfThePerson);

            //Func delegate is like action but it encapsualtes methods that have a return type
            Func<string, string> personAdress = (string adress) => { return $"My adress is {adress}"; };

            ShowAdress(personAdress);
        }

        public static void PersonName()
        {
            Console.WriteLine($"My name is no name.");

        }
        public static void PersonAge()
        {
            Console.WriteLine("My age is age");
        }
        public static void Person(Action<string> personName)
        {
            personName(" ");




        }
        public static void ShowAdress(Func<string,string> adress)
        {
            Console.WriteLine(adress(" "));
        }
        


    }
}
