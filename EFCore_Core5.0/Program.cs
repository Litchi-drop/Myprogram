using System;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_Core5._0
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (MyDbContext ctx = new MyDbContext())
            {
                //Book b1 = new Book();
                //b1.Title = "平凡的世界";
                //b1.PubTime = DateTime.Now.AddDays(-5);
                //b1.Price = 50;
                //b1.AuthorName = "YYC";
                //ctx.Books.Add(b1);
                //await ctx.SaveChangesAsync();

                var a = ctx.Books.Single(o => o.AuthorName == "YYC");


            }
        }
    }
}
