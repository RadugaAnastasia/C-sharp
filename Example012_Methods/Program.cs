// ВИД 1 - Ничего не принимают, ничего не возвращают (Void)
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1(); //Так вызывают метод


// ВИД 2 - Что-то принимают, ничего не возвращают (Void)
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg,int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i ++; //инкремент
    }
}
Method21(msg: "Text", count: 4); // если используем именованные аргументы, можем писать их не по порядку

// ВИД 3 - Ничего не принимают, что-то возвращают (например, для генерации данных)
int Method3()
{
    return DateOnly.FromDateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// ВИД 4 - Что-то принимают, что-то возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // означает, что в result будет пустая строка result = ""

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
ConsoleWriteLine(res);

// Цикл со счетчиком FOR
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // означает, что в result будет пустая строка result = ""
    for( int i = 0; i < count; i++) //все собрали в одном месте
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
ConsoleWriteLine(res);

//Использование цикла в цикле.
//Классическая задача демонстрации метода - вывод таблицы умножения на экран

for( int i = 2; i <= 10; i++) 
{
    for( int j = 2; i <= 10; j++)
    {
        Console.WriteLine($" {i} x {j} = {i * j}"); //интерполяция строк
    }
    Console.WriteLine(); //искуственный разрый, чтобы вывод был через пробел
}