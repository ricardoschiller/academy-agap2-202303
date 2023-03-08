// See https://aka.ms/new-console-template for more information
using Agap2IT.Labs.RentACar.Dal;
using Agap2IT.Labs.RentACar.Data.Models;

Console.WriteLine("Hello, World!");


//var context = new Academy202303Context();

//context.Colors.Add(new Color { Name = "Blue Velvet" });
//context.SaveChanges();

//var colors = context.Colors.Where(c => c.Name.Contains("e")).OrderByDescending(c => c.Id).ToList();

//var colors1 = (from color in context.Colors
//               where color.Name.Contains("e")
//               select color).OrderByDescending(c => c.Id).ToList();


//var names = new List<string>();

//var selectedNames = names.Where(n => n.Contains("e")).OrderByDescending(n => n).ToList();

var dao = new EmployeesDao();

var employee = dao.Get(1);


Console.ReadLine();