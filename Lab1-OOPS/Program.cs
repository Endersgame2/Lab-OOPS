// That's not a working code short on time just tried to fullfill all the major requirements;
// LAB 1

class VendingMachine
{
    public static int SerialNumber;
    private Dictionary<int, int> MoneyFloat;
    private Dictionary<Product, int> inventory;

    public VendingMachine()
    {
        MoneyFloat = new();
        inventory = new();
    }

    public string StockItem(Product product, int quantity)
    {
        if (quantity < 0)
        {
            Console.WriteLine("Negative quantity");
        }
        if (inventory.ContainsKey(product))
        {
            inventory[product] += quantity;
            Console.WriteLine($"{quantity} has been added {product.Name}, Code:{product.Code}. Price:{product.Price}");
        }
        else
        {
            inventory.Add(product, quantity);
            Console.WriteLine($"{quantity} has been added {product.Name}, Code:{product.Code}. Price:{product.Price}");
        }

    }

    public string StockFloat(int MoneyDenomination, int quantity)
    {
        if (MoneyFloat.ContainsKey(MoneyDenomination))
        {
            MoneyFloat[MoneyDenomination] += quantity;
            Console.WriteLine($" There are {MoneyDenomination} + {MoneyFloat[MoneyDenomination]}");
        }
    }


    // top level 
    public string VendItem(string code, List<int> money)
    {
        if (string.IsNullOrEmpty(code)
        {
            Console.WriteLine("Invalid Code");
        }


        int totalMoney = 0;
        int amount = 0;
        StringBuilder sb = new();

        Dictionary<int, int> change = new();
        foreach (var item in money)
        {
            totalMoney += item;
        }


        amount = totalMoney;

        foreach (var item in inventory)
        {
            if(item.Key.Price > totalMoney)
            {
                Console.WriteLine("Insufficent Funds");
            }
            if(item.Value == 0)
            {
                Console.WriteLine("Alll out");
            }
        }
    }


}