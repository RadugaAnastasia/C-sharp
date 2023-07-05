//Посмотреть содержимое папки
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    } 
}
string path = "/Users/raduga/Downloads/02_LEARN/Geek Brains/C#/Examples/Example001_HelloConsole";
DirectoryInfo di = new DirectoryInfo(path);
CatalogInfo(path);

// Игра в пирамидки
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();

//Обход структур
string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                 0    1    2    3     4    5    6    7    8    9    10   11
void InOrderTraversa(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNull0rEmpty(tree[left])) IsNull0rEmpty(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNull0rEmpty(tree[right])) IsNull0rEmpty(right);
    }
}
