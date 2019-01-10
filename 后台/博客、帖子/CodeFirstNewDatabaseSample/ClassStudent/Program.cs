using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassStudent.Models;
using ClassStudent.BusinessLayer;

namespace ClassStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowClass();
            AddClass();
            ShowClass();
            Console.WriteLine("按任意键退出");
            Console.ReadKey();
        }
        static void AddClass()
        {
            Console.WriteLine("请增加新的班级名");
            string name = Console.ReadLine();
            Class classb = new Class();
            classb.ClassName = name;
            ClassBusinessLayer cbl = new ClassBusinessLayer();
            cbl.Add(classb);
        }
        static void ShowClass()
        {
            ClassBusinessLayer cbl = new ClassBusinessLayer();
            var ClassT = cbl.Show();
            foreach (var key in ClassT)
            {
                Console.WriteLine(key.ClassId + " " + key.ClassName);
            }
        }
        //static void Update()
        //{
        //    Console.WriteLine("请输入需要修改的博客id");
        //    int id = int.Parse(Console.ReadLine());
        //    BlogBusinessLayer bbl = new BlogBusinessLayer();
        //    Blog blog = bbl.Query(id);
        //    Console.WriteLine("请输入博客新名字");
        //    string name = Console.ReadLine();
        //    blog.Name = name;
        //    bbl.Update(blog);
        //}
        //static void Delete()
        //{
        //    BlogBusinessLayer bbl = new BlogBusinessLayer();
        //    Console.WriteLine("请输入需要删除到博客id");
        //    int id = int.Parse(Console.ReadLine());
        //    Blog blog = bbl.Query(id);
        //    bbl.Delete(blog);
        //}
    }
}
