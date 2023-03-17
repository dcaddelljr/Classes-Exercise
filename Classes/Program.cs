namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var truck = new Car();

            truck.Make = "Ford";
            truck.Model = "F150";
            truck.Year = "2017";

            truck.myCar();
        }
    }
}
