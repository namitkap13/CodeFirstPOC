using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CFDemo
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            using ( var db = new BlogContext())
            {
                Console.WriteLine("Enter the name of new vlog:");
                var name = Console.ReadLine();

                var blog = new Blog() { BlogName = name };
                db.Blogs.Add( blog );
                db.SaveChanges();

                var query = from b in db.Blogs 
                            orderby b.BlogName
                            select b;
                
                foreach( var item in query )
                {
                    Console.WriteLine( item.BlogName );
                }
            }
        }
    }
}