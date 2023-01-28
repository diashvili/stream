using G15_13092022;

Product product1 = new(1) { Name = "Product 1", Price = 15 };
Product product2 = new(2) { Name = "Product 2", Price = 1 };
Product product3 = new(3) { Name = "Product 3", Price = 199 };
Product product4 = new(4) { Name = "Product 4", Price = 155 };

Catalogue products = new();
products.Add(product1);
products.Add(product2);
products.Add(product3);
Product product5 = new(5) { Name = "Product 5", Price = 1 };
Product product6 = new(6) { Name = "Product 6", Price = 199 };
Product product7 = new(7) { Name = "Product 7", Price = 15 };

Catalogue catalogue = new();
catalogue.Add(product5);
catalogue.Add(product6);
catalogue.Add(product7);
products.AddRange(catalogue);
foreach (var item in products)
{
    Console.WriteLine(item.ToString());
}

Product product8 = new(8) { Name = "Product 5", Price = 1 };
Product product9 = new(9) { Name = "Product 6", Price = 199 };
Product product10 = new(10) { Name = "Product 7", Price = 15 };

Catalogue catalogue2 = new();

catalogue2.Add(product8);
catalogue2.Add(product9);
catalogue2.Add(product10);

products.InsertRange(0, catalogue2);
Console.WriteLine("_--------------------------");
foreach (var item in products)
{
    Console.WriteLine(item.ToString());
}



//catalogue.Load(@"D:\Products.txt");