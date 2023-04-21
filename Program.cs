using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new ClinicContext())
            {
                var person = new user() { userName = "Billy705", firstName = "Bill", lastName = "Morgan" };

                ctx.Users.Add(person);
                ctx.SaveChanges();
            }
        }
    }
}