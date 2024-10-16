namespace Rectangle_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the rectangle calculator");
            String choice;
            do
            {
                Console.Write("Enter width: ");
                double width = double.Parse(Console.ReadLine());

                Console.Write("Enter length: ");
                double length = double.Parse(Console.ReadLine());

                double area = length * width;

                double perimeter = (length * 2) + (width * 2);

                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimeter: {perimeter}");

                Console.Write("Would you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower().Trim();
            }while(choice == "y");
        }
    }
}
