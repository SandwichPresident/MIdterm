namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumx3(2,3));
            static int sumx3(int x, int y)
            {
                int answer;
                answer = (x + y) * 3;
                return answer;
                //heres a comment for ya
            }
        }
    }
}
