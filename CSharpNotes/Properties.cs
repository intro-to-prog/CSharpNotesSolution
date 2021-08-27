using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharpNotes
{
    public class Properties
    {
        [Fact]
        public void UsingProperties()
        {
            var bob = new Employee();
            bob.FirstName = "Robert";
            Assert.Equal("Robert", bob.FirstName);

            Assert.Equal(180000, bob.Salary);

            bob.GiveRaise(10);
            Assert.Equal(180010, bob.Salary);
        }

        [Fact]
        public void ObjectInitializers()
        {
            var sue = new Employee
            {
                FirstName = "Susan",
                LastName = "Jones"
            };

            var bread = new Product("3939", "Milk", 3.99m, 12);
           // var beer = new Product()
            Assert.Equal("Milk", bread.Name);


            var dune = new Movie("Dune")
            {
                Director = "David Lynch",
                YearReleased = 1983
            };

            Assert.Equal("Dune", dune.Title);

            var updatedDune = dune with { YearReleased = 1984 };


        }
    }

    public class Employee
    {
        // "Auto Properties"

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; private set; } = 180000;

        public void GiveRaise(decimal amount)
        {
            Salary += amount;
        }


    }
    public class Product
    {
        public Product(string sku, string name, decimal price, int qty)
        {
            Sku = sku;
            Name = name;
            Price = price;
            Qty = qty;
        }
        public Product(string sku, string name, decimal price): this(sku, name, price, 0)
        {
           
        }
        public string Sku { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Qty { get; private set; }
    }

    public record Movie
    {
        public Movie(string title)
        {
            Title = title;
        }
        public string Title { get;  }
        public string Director { get; init; }
        public int YearReleased { get; init; }
    }
}
