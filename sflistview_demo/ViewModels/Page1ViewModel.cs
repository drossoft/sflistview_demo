using sflistview_demo.Model;

namespace sflistview_demo.ViewModels;

public partial class Page1ViewModel : BaseViewModel
{

    public ObservableCollection<Item> Items { get; set; }

    public Page1ViewModel() 
    {
        Items = CreateItemsList();
    }

    private ObservableCollection<Item> CreateItemsList()
    {
        ObservableCollection<Item> items = new ObservableCollection<Item>();

        for (int i=0; i<100; i++)
        {
            items.Add(new Item() { Image = $"iconblank.png", Name = $"Item {i + 1}" });
        }

        return items;
    }
}
