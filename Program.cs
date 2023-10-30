using ContosoPizza.Data;
using ContosoPizza.Seed;

using ContosoPizzaContext context = new ContosoPizzaContext();

Seed.SeedProducts(context);