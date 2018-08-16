using System;
using System.Collections.Generic;

namespace mysql
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Database.EnsureCreated();

                Task t1 = new Task { TaskName = "Test1", TaskInterval = 10, IpPLC = "10.11.20.120", TagName = "TagName1" };
                Task t2 = new Task { TaskName = "Test2", TaskInterval = 15, IpPLC = "10.11.23.126", TagName = "TagName2" };
                Task t3 = new Task { TaskName = "Test3", TaskInterval = 25, IpPLC = "10.11.18.118", TagName = "TagName3" };
                Task t4 = new Task { TaskName = "Test4", TaskInterval = 30, IpPLC = "10.11.21.121", TagName = "TagName4" };
                Task t5 = new Task { TaskName = "Test5", TaskInterval = 35, IpPLC = "10.11.10.10", TagName = "TagName5" };
                Task t6 = new Task { TaskName = "Test6", TaskInterval = 45, IpPLC = "10.11.29.78", TagName = "TagName6" };
                Task t7 = new Task { TaskName = "Test7", TaskInterval = 55, IpPLC = "10.11.19.45", TagName = "TagName7" };
                Task t8 = new Task { TaskName = "Test8", TaskInterval = 60, IpPLC = "10.11.43.34", TagName = "TagName8" };
                Task t9 = new Task { TaskName = "Test9", TaskInterval = 75, IpPLC = "10.11.56.23", TagName = "TagName9" };

                Data d1 = new Data { Date = DateTime.Now, Value = 12, Task = t1 };
                Data d2 = new Data { Date = DateTime.Now, Value = 15, Task = t2 };
                Data d3 = new Data { Date = DateTime.Now, Value = 12, Task = t3 };
                Data d4 = new Data { Date = DateTime.Now, Value = 15, Task = t4 };
                Data d5 = new Data { Date = DateTime.Now, Value = 12, Task = t5 };
                Data d6 = new Data { Date = DateTime.Now, Value = 15, Task = t6 };
                Data d7 = new Data { Date = DateTime.Now, Value = 12, Task = t7 };
                Data d8 = new Data { Date = DateTime.Now, Value = 15, Task = t8 };
                Data d9 = new Data { Date = DateTime.Now, Value = 12, Task = t9 };

                Random r1 = new Random();

                List<Data> dList = new List<Data>();

                for (int i = 0; i < 100; i++)
                {
                    d1 = new Data { Date = DateTime.Now, Value = r1.Next(-100, 100), Task = t1 };
                    d2 = new Data { Date = DateTime.Now, Value = r1.Next(-100, 100), Task = t2 };
                    d3 = new Data { Date = DateTime.Now, Value = r1.Next(-100, 100), Task = t3 };
                    d4 = new Data { Date = DateTime.Now, Value = r1.Next(-100, 100), Task = t4 };
                    d5 = new Data { Date = DateTime.Now, Value = r1.Next(-100, 100), Task = t5 };
                    d6 = new Data { Date = DateTime.Now, Value = r1.Next(-100, 100), Task = t6 };
                    d7 = new Data { Date = DateTime.Now, Value = r1.Next(-100, 100), Task = t7 };
                    d8 = new Data { Date = DateTime.Now, Value = r1.Next(-100, 100), Task = t8 };
                    d9 = new Data { Date = DateTime.Now, Value = r1.Next(-100, 100), Task = t9 };
                    context.Datas.Add(d1);
                    context.Datas.Add(d2);
                    context.Datas.Add(d3);
                    context.Datas.Add(d4);
                    context.Datas.Add(d5);
                    context.Datas.Add(d6);
                    context.Datas.Add(d7);
                    context.Datas.Add(d8);
                    context.Datas.Add(d9);
                }

                foreach (Data d in context.Datas)
                {
                    //Console.WriteLine(d.Task.Time.ToShortTimeString() + ' ' + d.Value);
                }
                context.SaveChanges();
            }
            Console.WriteLine("OK");
        }
    }
}
