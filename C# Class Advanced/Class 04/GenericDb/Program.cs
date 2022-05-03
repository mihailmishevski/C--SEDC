using GenericDb.Database;
using GenericDb.Entities;

List<Item> items = new List<Item>()
{
    new Item(1, "Shoe", 1),
    new Item(2, "Shoe", 2),
    new Item(3, "Shoe", 3),
    new Item(4, "Shoe", 5),
    new Item(5, "Shoe", 4),
    new Item(6, "Shoe", 3)
};

Cart cart = new Cart(2, "123", items);
Cart cartTwo = new Cart(1, "456", items);

Console.WriteLine(Cart.Equals(cart, cartTwo));

InMemoryDatabase.CartDatabase.Add(cart);
InMemoryDatabase.CartDatabase.Add(cartTwo);

var cartFromDb = InMemoryDatabase.CartDatabase.Get(cart.Id);

items.ForEach(x => InMemoryDatabase.ItemDatabase.Add(x));

List<Item> itemsWithQuantityThree = InMemoryDatabase.ItemDatabase.GetItemsWithQuantitiy(3);

Console.WriteLine(itemsWithQuantityThree.Count);