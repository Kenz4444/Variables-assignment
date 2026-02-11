using System.Reflection.Metadata;

namespace Variables_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kenzie!
            //Task One

            int roomNumber; double price; string computerScience;

            roomNumber = 29;
            price = 2.99;
            computerScience = "I am learning about Computer Science!";

            Console.WriteLine("The room number is " + ("#") + roomNumber);
            Console.WriteLine();
            Console.WriteLine("The price is " + price.ToString("C"));
            Console.WriteLine();
            Console.WriteLine(computerScience);
            Console.WriteLine();


            //Task Two
            string fullName; int graduationYear;

            fullName = "Kenzie McIntyre";
            graduationYear = 2027;

            Console.WriteLine("My name is " + fullName + ", and I graduate in " + graduationYear);
            Console.WriteLine();

            //Task Three
            const double Pi = double.Pi;
            double radius = 6.0;
            double area = Math.Round(Pi * radius * radius, 2);


            Console.WriteLine("The area of a circle with the radius " + radius + ("cm, is ") + area + ("cm."));
            Console.WriteLine();    

            //Task Four 
            double height = 2.0; 
            double Base= 4.0;
            double area2 = Math.Round(Base * height)/2;

            Console.WriteLine("My favoutite formula is A=BH/2");
            Console.WriteLine("If I had a triangle with the base being 4cm and height being 2cm what would the area be?");
            Console.WriteLine("The area would be " + area2 + ("cm."));


         

        }


    }
}
