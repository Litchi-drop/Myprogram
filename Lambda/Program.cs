using Lambda.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<People> list1 = new List<People>();
            list1.Add(new People { name = "小李",age =20});
            list1.Add(new People { name = "小王", age = 22 });
            list1.Add(new People { name = "小炎", age = 28 });


            IEnumerable<string> a = list1.Select(o => o.name);
            foreach (string item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            //Action f1 = delegate () {
            //    Console.WriteLine("test");
            //};

            //Action<string,int> f2 = delegate (string n, int i) {

            //    Console.WriteLine($"n= {n},i={i}");
            //};

            //f2("yzk", 18);

            //Func<int, int, int> f3 = delegate (int i, int j)
            //  {
            //      return i + j;
            //  };

            //Func<int> f4 = delegate () {

            //    return 4;
            //};

            ////对于有参数有返回值的匿名方法省略delegate 加上=>
            //Func<int, int, int> f5 =  (int i, int j) => 
            //{
            //    return i + j;
            //};

            //Action<int> a231 = (int i) => Console.WriteLine("我是有参数没有返回值");
            //a231(2);

            ////对于有参数有返回值的匿名方法省略delegate，还可以省略参数类型 加上=>
            //Func<int, int, int> f6 = ( i,  j) =>
            //{
            //    return i + j;
            //};

            ////对于没有返回值的匿名方法，且方法体只有一行代码，可以省略大括号
            //Action f11 =  () => 
            //Console.WriteLine("asdf");

            ////对于有返回值的匿名方法，方法体只有一行代码，可以省略大括号以及return
            //Func<int, int, int> f66 = (i, j) => i + j;

            ////对于只有一个参数的匿名方法，可以省略()
            //Action<int> a = i => Console.WriteLine(i);
            //Func<int, bool> func =  i =>  i > 0; 


            //Console.WriteLine(f66(5, 8) ); 

            Console.ReadLine();
        }
    }
}
