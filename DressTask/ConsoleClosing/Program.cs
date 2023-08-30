using ConsoleClosing.Dal;
using ConsoleClosing.Models;
using System;
using System.Linq;

namespace ConsoleClosing {
    internal class Program {
        static void Main(string[] args) {
            DataContext data = new DataContext();

            //Console.WriteLine("Insert dress type (1: Skirt / 2: Sun)");

            //var num = Console.ReadLine();
            //if (num == "1") {
            //    data.Dresses.Add(new Skirt { Name = "Skr 1", Lenght = 43 });
            //    data.SaveChanges();
            //}
            //else if (num == "2") {
            //    data.Dresses.Add(new Sun {
            //        Name = "Sun 2",
            //        Color = ColorType.Red | ColorType.Yellow | ColorType.Green
            //    });
            //    data.SaveChanges();
            //}
            //else
            //    Console.WriteLine("Not a number");

            //data.Dresses.ToList().ForEach(d => Console.WriteLine(d.Name));
            
            data.Dresses
                .OfType<Sun>()
                .ToList()
                .ForEach(d => Console.WriteLine(d.Color));
        }
    }
}
