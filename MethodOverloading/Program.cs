namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static float Add(float x, float y) { 
            return x + y; 
        }
        public static string Add (int x, int y, bool z)
        {
            if (z)
            {
                string isPlural;
                if (x + y > 1)
                {
                    isPlural = " dollars";
                }
                else
                {
                    isPlural = " dollar";
                }
                return x + y + isPlural;
            }
            return (x + y).ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
