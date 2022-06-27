internal class VendingMachineBase
{

    public string StockItem(Product product, int quantity)
    {
        if (quantity < 0)
        {
            Console.WriteLine("Negative quantity");
        }
        if (inventory.ContainsKey(product))
        {
            inventory[product] += quantity;
            Console.WriteLine($"{quantity}{product.name} has been added, Code:{product.code};

    }

    }
}