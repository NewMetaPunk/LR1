Write("Введите символ и я определю является ли оно числом: ");
bool check=int.TryParse(ReadLine(), out int z);
WriteLine(check == true ? "Это число." : "Это не число.");
WriteLine("Для завершения программы нажмите любую клавишу...");
ReadKey();