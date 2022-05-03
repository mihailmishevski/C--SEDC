using Polymorphism.Entities;
using Polymorphism.Helper;

User user = new User("Miki");

user.SayHello();

user.SayHello(LanguageHelper.MACEDONIAN);