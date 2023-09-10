using System.Text;

namespace HomeWork03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("✨ This is Hillel 2023 C# Pro homework #03");
            Moroz();
        }
        static void Moroz()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("👉👈 Moroz 💗");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
