
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Classic Poetry Anthology",
        Price = 20.00M,
        ProductTypeId = 1 
    },
    new Product()
    {
        Name = "Modern Poems Collection",
        Price = 25.00M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Trumpet - Beginner's Model",
        Price = 100.00M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Professional Trombone",
        Price = 300.00M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "French Horn - Classic Edition",
        Price = 250.00M,
        ProductTypeId = 2
    }
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 

List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Id = 1,
        Title = "Poetry Book"
    },
    new ProductType()
    {
        Id = 2,
        Title = "Brass Instrument"
    }
};

//put your greeting here
Console.WriteLine("Welcome to Brass & Poem - Your one-stop shop for poetry and brass instruments!");

//implement your loop here
bool isRunning = true;
while (isRunning)
{
    DisplayMenu();
    string userInput = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            DisplayAllProducts(products, productTypes);
            break;
        case "2":
            DeleteProduct(products, productTypes);
            break;
        case "3":
            AddProduct(products, productTypes);
            break;
        case "4":
            UpdateProduct(products, productTypes);
            break;
        case "5":
            Console.WriteLine("Thank you for using Brass & Poem. Goodbye!");
            isRunning = false;
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}

void DisplayMenu()
{
    Console.WriteLine("\nPlease choose an option:");
    Console.WriteLine("1. Display all products");
    Console.WriteLine("2. Delete a product");
    Console.WriteLine("3. Add a new product");
    Console.WriteLine("4. Update product properties");
    Console.WriteLine("5. Exit");
    Console.Write("Enter your choice: ");
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }