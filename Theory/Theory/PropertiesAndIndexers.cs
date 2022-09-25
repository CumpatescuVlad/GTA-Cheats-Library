namespace Basic
{
    internal class PropertiesAndIndexers
    {
        //Properties are some kind of varaibles taht can hold multiple values,thry have accesors get;se; and
        //they can acces private fields , they are verry usefull when you don`t canr to reapeat youreself 
        //props can also be autoimplemented when thay don`t acces any field

        private string _name;
        public string Name { get => _name; set => _name = value; }

        public int Age { get; set; }

        //Indexers allow an object to gain array properties

        public string[] names = new string[50];

        public string this[int index] { get => names[index]; set => names[index] = value; }


        public static void Execute()
        {

            PropertiesAndIndexers names = new PropertiesAndIndexers();

            names[0] = "John";
            names[1] = "Max";
            names[2] = "Jay";

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(names[i]);
            }
        }


    }

}
