Write("Введите минимальное число: ");
int.TryParse(ReadLine(), out int min);
Write("Введите максимальное число: ");
int.TryParse(ReadLine(), out int max);

int[,] mass = new int[5,5];

Random rand = new Random();

for (int i = 0; i < 5; i++)
{
    for (int x = 0; x < 5; x++)
    {
        mass[i, x] = rand.Next(min, max+1);
    }
}
WriteLine("Ваш массив: ");
for (int i = 0; i < 5; i++)
{
    for (int x = 0; x < 5; x++)
    {
        Write(mass[i, x]+" ");
    }

    WriteLine();
}
WriteLine("Для завершения программы нажмите любую клавишу...");
ReadKey();