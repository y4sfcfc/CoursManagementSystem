namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("balinizi daxil edin:");
            int sonuc = int.Parse(Console.ReadLine());

            if(sonuc > 50 )
            {
                Console.WriteLine("ugurlu");
            }
            else { Console.WriteLine("ugursuz"); }


        }
    }
}
