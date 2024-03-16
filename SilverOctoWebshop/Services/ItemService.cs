using Models;

namespace Services;

public class ItemService
{
    public ItemService()
    {
        

    }

    public void AddItem(Item item)
    {
        if(item == null) throw new ArgumentNullException(nameof(item));
        var list = new List<Item>();
        var correctItem = list.FirstOrDefault(x => x.Price == 10);
    }
}
