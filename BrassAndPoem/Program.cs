
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new()
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
    if (products.Count == 0)
    {
        Console.WriteLine("No products available.");
        return;
    }

    Console.WriteLine("Available Products:");
    foreach (var product in products)
    {

        var productType = productTypes.FirstOrDefault(pt => pt.Id == product.ProductTypeId);
        string productTypeName = productType != null ? productType.Title : "Unknown Type";


        Console.WriteLine($"Name: {product.Name}, Price: {product.Price:C}, Type: {productTypeName}");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
 
    if (products.Count == 0)
    {
        Console.WriteLine("No products available to delete.");
        return;
    }

    Console.WriteLine("Select a product to delete:");
   
    for (int i = 0; i < products.Count; i++)
    {
        var product = products[i];
        var productType = productTypes.FirstOrDefault(pt => pt.Id == product.ProductTypeId);
        string productTypeName = productType != null ? productType.Title : "Unknown Type";
        Console.WriteLine($"{i}: {product.Name} (Type: {productTypeName}, Price: {product.Price:C})");
    }

    Console.Write("Enter the product number to delete: ");
    if (!int.TryParse(Console.ReadLine(), out int productIndex) || productIndex < 0 || productIndex >= products.Count)
    {
        Console.WriteLine("Invalid product number.");
        return;
    }

    products.RemoveAt(productIndex);

    Console.WriteLine("Product deleted successfully.");
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{

    Console.Write("Enter product name: ");
    string name = Console.ReadLine();

    Console.Write("Enter product price: ");
    decimal price = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Product Types:");
    foreach (var type in productTypes)
    {
        Console.WriteLine($"{type.Id}: {type.Title}");
    }

    Console.Write("Enter Product Type ID: ");
    int productTypeId = int.Parse(Console.ReadLine());

    var newProduct = new Product
    {
        Name = name,
        Price = price,
        ProductTypeId = productTypeId
    };

    products.Add(newProduct);
    Console.WriteLine("Product added successfully.");
}


void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    if (products.Count == 0)
    {
        Console.WriteLine("No products available to update.");
        return;
    }

    Console.WriteLine("Select a product to update:");
    for (int i = 0; i < products.Count; i++)
    {
        var product = products[i];
        var productType = productTypes.FirstOrDefault(pt => pt.Id == product.ProductTypeId);
        string productTypeName = productType != null ? productType.Title : "Unknown Type";
        Console.WriteLine($"{i}: {product.Name} (Type: {productTypeName}, Price: {product.Price:C})");
    }

    Console.Write("Enter the product number to update: ");
    if (!int.TryParse(Console.ReadLine(), out int productIndex) || productIndex < 0 || productIndex >= products.Count)
    {
        Console.WriteLine("Invalid product number.");
        return;
    }

    var selectedProduct = products[productIndex];

    Console.Write("Enter new name (leave blank to keep current): ");
    string newName = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(newName))
    {
        selectedProduct.Name = newName;
    }

    Console.Write("Enter new price (leave blank to keep current): ");
    string newPriceInput = Console.ReadLine();
    if (decimal.TryParse(newPriceInput, out decimal newPrice))
    {
        selectedProduct.Price = newPrice;
    }

    Console.WriteLine("Product Types:");
    foreach (var type in productTypes)
    {
        Console.WriteLine($"{type.Id}: {type.Title}");
    }
    Console.Write("Enter new Product Type ID (leave blank to keep current): ");
    string newTypeIdInput = Console.ReadLine();
    if (int.TryParse(newTypeIdInput, out int newTypeId))
    {
        selectedProduct.ProductTypeId = newTypeId;
    }

    Console.WriteLine("Product updated successfully.");
}


// don't move or change this!
public partial class Program { }