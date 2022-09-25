namespace Basic
{
    public class Collections
    {
        //Collections are generic classes that allow to store multiple value and iterate trough enach one 
        //you can list a class with props , by creating an object
        //or you can use dictionary to assign a key to a vlue

        public void ShowParts()
        {

            List<WashingMachine> machines = new List<WashingMachine>();

            machines.Add(new WashingMachine { Parts = "Body" });
            machines.Add(new WashingMachine { Parts = "Mottor" });
            machines.Add(new WashingMachine { Parts = "Pump" });
            machines.Add(new WashingMachine { Parts = "Hose" });
            machines.Add(new WashingMachine { Parts = "Tank" });

            foreach (WashingMachine machine in machines)
            {
                Console.WriteLine(machine.Parts);
            }

            Dictionary<string, string> prices = new Dictionary<string, string>();

            prices.Add("LOW", "High");
            prices.Add("Medium", "High");
            prices.Add("High", "Low");

            foreach (var price in prices)
            {
                Console.WriteLine(price.Key);
                Console.WriteLine(price.Value);
            }

        }



    }
    public class WashingMachine
    {
        public string Parts { get; set; }

    }

}
