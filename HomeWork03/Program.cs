using System.Text;

namespace HomeWork03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("✨ This is Hillel 2023 C# Pro homework #03");
            Console.WriteLine("Approve pr or bad luck :)");

            List<object> projectMembers = new()
            {
                new MorozHordii(),
                new ZorinMykhailo(),
                new BoiarynovMaksym(),
                new PyslarNataliia(),
                new EksarovPavlo(),
        };

            Console.WriteLine("\n👥 Project members:");
            foreach (var member in projectMembers)
                Console.WriteLine($" 👤 {member.ToString()}");

            Console.WriteLine("\n😜 Project finished!\n");
        }
    }
}