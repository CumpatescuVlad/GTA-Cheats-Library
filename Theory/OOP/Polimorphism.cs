namespace OOP
{
    //Polimorphysm is the fourth OOP principle whre an object could have multiuple form
    //a derived class object cand behave as being a base class object

    public class Polimorphism
    {
        public string Materials { get; set; }

        public virtual void ShowMaterials()
        {
            Materials = "Concrete";

            Console.WriteLine($"This building is mage out of materials ");


        }

        public static void Execute()
        {
            var build = new List<Polimorphism>() { new Hotel(), new House(), new PoliceStation() };

            foreach (var building in build)
            {
                building.ShowMaterials();

            }
        }



    }
    public class House : Polimorphism
    {
        public override void ShowMaterials()
        {
            Console.WriteLine("This building is made out of DryWall");

            base.ShowMaterials();
        }

    }
    public class PoliceStation : Polimorphism
    {
        public override void ShowMaterials()
        {
            Console.WriteLine("This building is made out of Bricks");

            base.ShowMaterials();
        }

    }
    public class Hotel : Polimorphism
    {
        public override void ShowMaterials()
        {
            Console.WriteLine("This building is made out of Glass");

            base.ShowMaterials();
        }

    }
}
