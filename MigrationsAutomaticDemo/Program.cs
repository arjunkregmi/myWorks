using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationsAutomaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BlogContext())
            {
                db.Blogs.Add(new Blog { Name = "Shaher Regmi" });
                db.SaveChanges();

                foreach(var blog in db.Blogs)
                {
                    Console.WriteLine(blog.Name);
                }
            }
        }
    }
}
