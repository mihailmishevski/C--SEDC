using GenericsAndExentions.Entities;

List<string> stringList = new List<string>();

Order orderOne = new Order(1);
Order orderOneCopy = new Order(1);
Order orderTwo = new Order(2);

Cart cartOne = new Cart(1);

Console.WriteLine(orderOne.IsEqualTo(orderTwo)); 