namespace OperatorExercise
{
    public class Program
    {
 
        static void Main(string[] args)
        {       
            int a = 17;
            int b = 4;


            int sum = a + b;
            int minus = a - b;
            int multiplication = a * b;

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}+{b} = " + sum);
            Console.WriteLine($"{a}-{b} = " + minus);
            Console.WriteLine($"{a}*{b} = " +multiplication);
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            Console.WriteLine($"Remainder is " + remainder);


            Console.WriteLine("Please enter the radius of your circle:");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));

        }

        
        public static double AreaOfCircle(double radius)
        {

            var area = Math.PI * Math.Pow(radius, 2);

            return area;
            
        }
    }
}
