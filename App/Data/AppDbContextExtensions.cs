using App.Models;

namespace App.Data;
public static class AppDbContextExtensions
{
    public static void Seed(this AppDbContext dbContext)
    {
        
        if (!dbContext.Cars.Any())
        {

            var cars = new List<Car>()
            {
            new Car()
            {
                Id = 1,
                Marque = "Ferrari",
                Model = "F40",
                CarsType = 1,
                CreationDate = new DateTime(1987, 01, 01),
                Power =7
            },
            new Car()
            {
                Id = 2,
                Marque = "Lamborghini",
                Model = "Huracan",
                CarsType = 1,
                CreationDate = new DateTime(2014, 01, 01),
                Power =7

            },
            new Car()
            {
                Id = 3,
                Marque = "Ford",
                Model = "Mustang 67’",
                CarsType = 2,
                CreationDate = new DateTime(1967, 01, 01),
                Power =3
            },
              new Car()
            {
                Id = 4,
                Marque = "Dodge",
                CarsType = 5,
                CreationDate = new DateTime(2021, 01, 01),
                Power =5

            },
              new Car()
            {
                Id = 5,
                Marque = "Pagani",
                Model = "Huayra R",
                CarsType = 4,
                CreationDate = new DateTime(2018, 01, 01),
                Power =9

            },
              new Car()
            {
                Id = 6,
                Marque = "Bugatti",
                Model = "Chiron",
                CarsType = 4,
                CreationDate = new DateTime(2019, 01, 01),
                Power =10

            },
              new Car()
            {
                Id = 7,
                Marque = "Toyota",
                Model = "Supra Yakuza Edition",
                CarsType = 8,
                CreationDate = new DateTime(1995, 01, 01),
                Power =7

            },
                new Car()
            {
                Id = 8,
                Marque = "Honda",
                Model = "S2000 Racing",
                CarsType = 6,
                CreationDate = new DateTime(2009, 01, 01),
                Power =6

            },
                new Car()
            {
                Id = 9,
                Marque = "BMW",
                Model = "E30",
                CarsType = 6,
                CreationDate = new DateTime(1991, 01, 01),
                Power =6

            },
                new Car()
            {
                Id = 10,
                Marque = "Porsche",
                CarsType = 7,
                Model = "911 GT3",
                CreationDate = new DateTime(2007, 01, 01),
                Power =7
            }
            };
            dbContext.Cars.AddRange(cars);
            dbContext.SaveChanges();
        };

        if (!dbContext.CarsTypes.Any())
        {

            var categoriesItems = new List<CarsType>()
            {
                new CarsType()
                {
                    Id = 1,
                    Name = "Super Car",
                    Description = ""
                },
                new CarsType()
                {
                    Id = 2,
                    Name = "American Legend",
                    Description = ""
                },
                new CarsType()
                {
                    Id = 3,
                    Name = "Italian Classic",
                    Description = ""
                },
                  new CarsType()
                {
                    Id = 4,
                    Name = "Hyper Car",
                    Description = ""
                },
                  new CarsType()
                {
                    Id = 5,
                    Name = "Muscle Car",
                    Description = ""
                },
                  new CarsType()
                {
                    Id = 6,
                    Name = "Sport car",
                    Description = ""
                },
                  new CarsType()
                {
                    Id = 7,
                    Name = "German Classics",
                    Description = ""
                },
                   new CarsType()
                {
                    Id = 8,
                    Name = "Japan Race Car",
                    Description = ""
                },
            };

            dbContext.CarsTypes.AddRange(categoriesItems);
            dbContext.SaveChanges();
        }
    }
}