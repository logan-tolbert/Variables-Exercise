namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //heading
            Console.WriteLine("\t- Variables Exercise -\n");


            //step 1: Declare and initialize variable
            string name = "Logan";
            int meaningOfLife = 42;
            char grade = 'A';
            bool enabled = false;
            double myDoubleNum = 14.25;
            decimal myDecimalNum1 = 42.3545654347m;
            decimal myDeciamlNum2 = 33.333897m;

            //step 2: interpolate variables to string
            Console.WriteLine("Type\t\tUsage");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"string\t| My name is {name}\n");
            Console.WriteLine($"int\t| The meaning of life is {meaningOfLife}\n");
            Console.WriteLine($"char\t| I got an \'{grade}\' in Computer Science!\n");
            Console.WriteLine($"bool\t| Enabled = {enabled}\n");
            Console.WriteLine($"double\t| Starting Pay: ${myDoubleNum}\n");
            Console.WriteLine($"decimal\t| {myDecimalNum1} * {myDeciamlNum2} = {myDecimalNum1 * myDeciamlNum2}\n");
            
        }
    }
}
