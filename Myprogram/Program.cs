using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Myprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "2023-01-06 13点提交新内容";
string str1 = "这是在Gitee上编辑的内容";
            dynamic dyn = 1.1;
            dyn += "1";
            int i = 1;
            Console.WriteLine("dyn={0},dyn的类型{1}",dyn, dyn.GetType());

            int key;
            for(key = 0;key < 10 ;k++)
            {
                //这是从GitLab上面提交的内容
                Console.WriteLine("key的值为{0}",key);
            }

            #region
            Del handler = new Del(DelMethod);
            MethodWrit(1,2,handler);
            Console.WriteLine("请输入一个邮箱");
            //string email = Console.ReadLine();
            //Regex regex = new Regex(@"\b(\w)+(\.\w)*@(\w)+((\.\w+)+)\b");
            //if (regex.IsMatch(email))
            //{
            //    Console.WriteLine("邮箱格式正确。");
            //}
            //else
            //{
            //    Console.WriteLine("邮箱格式不正确。");
            //}


            Regex regex1 = new Regex(@"^\w{6,18}$");//验证用户密码 长度在6-18之间，只能包含英文和数字
            if (regex1.IsMatch("abcdef1gj^"))
            {
                Console.WriteLine("正确。");
            }
            else
            {
                Console.WriteLine("错误。");
            }


            Regex regex2 = new Regex(@"^[1-9][0-9]{4,}@qq.com$");
            if (regex2.IsMatch("10000@qq.com"))
            {
                Console.WriteLine("邮箱正确。");
            }
            else
            {
                Console.WriteLine("邮箱错误。");
            }


            Program p1 = new Program();
            int x =10;
            int y = 20;
            p1.GetValue(ref x, ref y);

            Console.WriteLine("{0}",x);
            #endregion
            
            Console.WriteLine("请输入一个数字！");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}的阶乘为：{1}",num, JC(num));

            Console.ReadLine();
        }

        static int JC(int num) 
        {
            if (num == 0)
            {
                return 1;
            }
            if (num <= 0)
            {
                return 1;
            }
            return num * JC(num - 1);

        }


        public delegate void Del(string message);

        public static void DelMethod(string message) 
        {
            Console.WriteLine(message);
        }

        public static void MethodWrit(int paramter1, int paramter2, Del CallBack)
        {

        }

        public void GetValue(ref int x, ref int y) 
        {
            //x = 1000;
            //y = 10;
        
        }

    }

    /// <summary>
    /// 发布者
    /// </summary>
    public class PublishEvent 
    {
        public delegate void NoticeHandler(string message);
        public event NoticeHandler NoticeEvent;

        public void Works() 
        {
            OnNoticed();
        }

        protected virtual void OnNoticed() 
        {
            if (NoticeEvent != null)
            {
                NoticeEvent("Notice发部的报警信息！");
            }
        
        }
    }

    /// <summary>
    /// 订阅者
    /// </summary>
    public class SubsrcribEvent 
    {
        public SubsrcribEvent(PublishEvent pub) { pub.NoticeEvent += PrintResult; }

        void PrintResult(string message) 
        {
            Console.WriteLine(string.Format("已收到{0}！",message)) ;
        }
    
    }


}
