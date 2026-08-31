using Infrastructure;

namespace Service;

public interface IGroceryService
{
    List<object> GetGroceries();
}

public class GroceryService : IGroceryService
{
    private readonly MyFakeDatabase _db;

    public GroceryService(MyFakeDatabase db)
    {
        _db = _db;
        Console.WriteLine("Service has been instantied");
    }

    public List<object> GetGroceries()
    {
        return _db.MyObjects;
    }
}