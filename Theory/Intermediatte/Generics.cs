namespace Intermediatte
{
    public class Generics : Cars<string>
    {

        //Generics are special type of classes that can work sith multiple types of data
        //memeber type is not declarred at the declarration time
        //type of data is declared when you create an object out of a generic class
        //Generics interact with inhertance trough covariance and contravariance
        //Covariance is when you assign a derived class object to a base class object
        //Contravariance is when you assign a base class object to a derived class

        Bulidings<string> buildingAdress = new Bulidings<string>();

        Bulidings<int> buildingHeight = new Bulidings<int>();

        //Cars<string> car = new Cars<string>() { Model = "Dacia 1310", Price ="15000" };


        public void CreateCar()
        {
            //Covariance
            IEnumerable<Generics> car = new List<Generics>() { new Generics { Model = "Bugatti", Price = "15.000" } };

            //Generics.CreateCar(car);    

            IEnumerable<Cars<string>> carInfo = car;


            Console.WriteLine(carInfo);

        }
        //Contravariace
        IEnumerable<Cars<string>> car = new List<Cars<string>>() { new Cars<string> { Model = "Dacia", Price = "3000" } };

        //IEnumerable<Generics> carInfo = car;

        public void CreateBuilding()
        {
            buildingAdress.Adress = "45 Avenue,near Malibu Club";

            buildingHeight.Height = 2500;

            Console.WriteLine($"This building is located in {buildingAdress.Adress} and is {buildingHeight.Height} tall.");

        }

    }
    class Bulidings<T>
    {
        public T Height { get; set; }

        public T Adress { get; set; }

    }
    public class Cars<T>
    {
        public T Price { get; set; }

        public T Model { get; set; }

        public static void CreateCar(IEnumerable<Cars<string>> cars)
        {

            foreach (Cars<string> car in cars)
            {
                Console.WriteLine(car.Model);
                Console.WriteLine(car.Price);
            }

        }
    }

}
