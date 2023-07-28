using Lecture12;

BaseBurgers baseBurgers = new BaseBurgers();
Console.Write("Choose Burger: 1) Cheeseburger : 2) Hamburger: 3) BrandedBurger: ");
var choise = int.Parse(Console.ReadLine());
switch (choise)
{
    case 1: baseBurgers.Cheeseburger();
    break;
    case 2: baseBurgers.Hamburger();
    break;
    case 3: baseBurgers.BrandedBurger();
    break;
}

