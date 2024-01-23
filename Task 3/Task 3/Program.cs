

namespace MySpace
{
    class Program
    {
       public static void Main(string[] args)
        {

            
            List<string> list = new List<string>();

            list.Add("ab");
            list.Add("abc");
            list.Add("abcde");
            list.Add("abcd");

            string result = list.OrderByDescending(x => x.Length).FirstOrDefault();

            Console.WriteLine(result);




        }

    }
}