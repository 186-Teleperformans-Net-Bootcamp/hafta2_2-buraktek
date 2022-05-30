using DependencyInversion.Concrete;
using System.Reflection;

Console.WriteLine("Please choose Coffee Machine Type:");
Console.WriteLine("1: Basic Coffee Machine, 2: Professional Coffee Machine");
int machine_type = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Please choose Coffee Type:");
int i = 1;
Type type;
if (machine_type == 1)
{
    BasicCoffeeMachine coffe = new BasicCoffeeMachine();
    type = coffe.GetType();
    foreach (var item in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
    {
        Console.WriteLine(i + ": " + item.Name);
        i++;
    }
    int coffeType = Convert.ToInt16(Console.ReadLine());
    switch (coffeType)
    {
        case 1:
            coffe.DoCaffeCrema();
            break;
        case 2:
            coffe.DoCoffee();
            break;
        case 3:
            coffe.DoEspresso();
            break;
    }
}
else
{
    ProCoffeeMachine coffe = new ProCoffeeMachine();
    type = coffe.GetType();
    foreach (var item in type.GetMethods())
    {
        Console.WriteLine(i + ": " + item.Name);
        i++;
        if (i == 7)
            break;
    }
    int coffeType = Convert.ToInt16(Console.ReadLine());
    switch (coffeType)
    {
        case 1:
            coffe.DoCappuccino();
            break;
        case 2:
            coffe.DoLatte();
            break;
        case 3:
            coffe.DoLatteMacchiato();
            break;
        case 4:
            coffe.DoCaffeCrema();
            break;
        case 5:
            coffe.DoCoffee();
            break;
        case 6:
            coffe.DoEspresso();
            break;
    }
}
