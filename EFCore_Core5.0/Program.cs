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
                //Cat obj = new Cat();
                //obj.Name = "拾玖";
                //obj.age = 1;
                //ctx.Cats.Add(obj);
                //await ctx.SaveChangesAsync();


                var infos = ctx.Cats.FirstOrDefault(o => o.Name == "拾玖");
                ctx.Cats.Remove(infos);
                await ctx.SaveChangesAsync();


            }
        }
    }
}
