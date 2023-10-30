using ContosoPizza.Models;
using ContosoPizza.Data;

namespace ContosoPizza.Seed;

public class Seed
{
    public static void SeedProducts(ContosoPizzaContext context)
    {
        Product veggieSpecial = new Product()
        {
            Name = "Veggie Special Pizza",
            Price = 9.99M
        };
        context.Products.Add(veggieSpecial);

        Product deluxeMeat = new Product()
        {
            Name = "Deluxe Meat Pizza",
            Price = 12.99M
        };
        // The Add method uses reflection to determine that deluxeMeat is a Product object,
        // and adds it to the Products DbSet.
        context.Add(deluxeMeat);

        context.SaveChanges();
    }
}
