using System.Text;

namespace HomeWork03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("✨ This is Hillel 2023 C# Pro homework #03");

            List<Object> projectMembers = new()
            {
                new ZorinMykhailo(),
                new BoiarynovMaksym()
            };

            Console.WriteLine("\n👥 Project members:");
            foreach (var member in projectMembers)
                Console.WriteLine($" 👤 {member.ToString()}");
        }
    }
}
