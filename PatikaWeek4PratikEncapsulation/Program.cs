using PatikaWeek4PratikEncapsulation;

 class Program
{
     static void Main(string[] args)
    {
        Car car1 = new Car("Lada" ,"Niva","Beyaz",4);
        car1.Display();

        Console.WriteLine("-----------------------------------------------------------");

        Car car2 = new Car("Honda", "S200", "Siyah", 2);
        car2.Display();

        Console.WriteLine("-----------------------------------------------------------");

        Car car3 = new Car("Renaul", "Laguna", "Kırmızı", 3);
        car3.Display();
       
    }

}