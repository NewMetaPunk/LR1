global using static System.Console;
using static Microsoft.VisualBasic.VBMath;
using classess;

//--------------------------------------------------------------------------------------Заполнение массива
Product[] spisok =
{
    new toy("Детский мяч", 100, "Россия", "Резина", 10),
    new toy("Сачок", 200, "Африка", "Пластик", 5),
    new book("Война и мир", "Толстой", 1000, "Книги России", 15),
    new book("Искусство войны", "Сунь цзы", 70050, "Китай", 50),
    new sport("Футбольный мяч", 800, "Германия", 10),
    new sport("Баскетбольный мяч", 1000, "Италия", 18),
};
//--------------------------------------------------------------------------------------

//--------------------------------------------------------------------------------------Выбор раздела
while (true)
{
    WriteLine("Введите что вы хотите найти:");
    WriteLine("1 - Игрушки");
    WriteLine("2 - Книги");
    WriteLine("3 - Спорт-инвентарь");
    WriteLine("4 - Список всех товаров");
    WriteLine("0 - Выход из программы");
    Write("Введите номер раздела: ");
    string choise = ReadLine();
    WriteLine();
    if (choise == "1")
    {
        WriteLine("Раздел игрушек");
        for (var i = 0; i < spisok.Length; i++)
        {
            var product = spisok[i];
            if (product.Vid == 1)
                Console.WriteLine(product.ToString());
        }

        WriteLine();
    }
    else if (choise == "2")
    {
        WriteLine("Раздел книг");
        for (var i = 0; i < spisok.Length; i++)
        {
            var product = spisok[i];
            if (product.Vid == 2)
                Console.WriteLine(product.ToString());
        }

        WriteLine();
    }
    else if (choise == "3")
    {
        WriteLine("Раздел спорт-инвентаря");
        for (var i = 0; i < spisok.Length; i++)
        {
            var product = spisok[i];
            if (product.Vid == 3)
                Console.WriteLine(product.ToString());
        }

        WriteLine();
    }
    else if (choise == "4")
    {
        WriteLine("Список всех товаров:");
        for (var i = 0; i < spisok.Length; i++)
        {
            var product = spisok[i];
            Console.WriteLine(product.ToString());
        }

        WriteLine();
    }
}
//--------------------------------------------------------------------------------------