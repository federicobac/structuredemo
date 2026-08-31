using Infrastructure;
using Infrastructure;
using LinqToDB;

namespace Service;

public interface IGroceryService
{
    public List<GroceryItem> GetGroceries();
    public void InsertGroceryItem();
}

public class GroceryService : IGroceryService
{
    private readonly GroceryDatabase _db;

    public GroceryService(GroceryDatabase db)
    {
        _db = db;
        Console.WriteLine("Service has been instantiated");
    }
    
    public List<GroceryItem> GetGroceries()
    {
        return _db.Groceries().ToList();
    }

    public void InsertGroceryItem()
    {
        var item = new GroceryItem()
        {
            Id = "helloworld" + new Random().Next(),
            GroceryName = "My grocery item"
        };
        _db.Insert(item);
    }
}