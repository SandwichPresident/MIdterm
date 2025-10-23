namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentNames = ["Alex", "Sam", "Lee", "Nick"];
            foreach (var name in studentNames)
            {
                Console.WriteLine("Welcome " + name + "!");
                if (name == "Nick")
                {
                                       Console.WriteLine("Wow! You have the same name as the instructor!");
                }
            }
        }
    }
}
