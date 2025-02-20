using module;

class Program
{
    public static void Main()
    {
        Cat cat1 = new Cat();
        cat1.Name = "Мурка";
        cat1.Breed = "Метис";
        cat1.BirthDay = new DateTime(2020, 6, 29);
        
        Cat cat2 = new();
        cat2.Name = "Барсик";
        cat2.BirthDay = new DateTime(2019, 9, 19);
        cat2.Breed = "Дворовая";

        Cat cat3 = cat1;


        Console.WriteLine(cat1.Name == cat2.Name);
        Console.WriteLine(cat1.Name == cat3.Name);
    }
}