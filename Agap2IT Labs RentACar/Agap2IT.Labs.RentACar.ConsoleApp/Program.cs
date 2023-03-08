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

//var dao = new EmployeesDao();
//var employee = dao.Get(1);

var dao = new GenericDao();

//dao.Add(new Client { Name = "Victor", Address = "Victor Address", Cellphone = "961234567", Nif = "12345678", LicenseNumber = "123184894" });

//dao.Add(new Model { Name = "Model S" });

//dao.Add(new Car { Brand = "Tesla", BuildDate = new DateTime(2023, 3, 8), ColorId = 1, License = "ab3422", ModelId = 1, Observations = string.Empty });

//dao.Add(new Rent { CarId = 1, ClientId = 1, StartDate = DateTime.UtcNow });


var rentingDao = new RentingDao();

//var cars = await rentingDao.GetCarsRentedByClientId(1);
var cars = await rentingDao.FindRedCarsRentedByClient("Amarelo");



Console.ReadLine();