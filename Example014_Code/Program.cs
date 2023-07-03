using System.Linq;

string text = "(1,2) (2,3) (4,5) (9,7)"
            .Replace("(", "")
            .Replace(")", "")
            ;
Console.WriteLine(text);

var data = text.Split(" ") //Split - разбей, разделителем будет пробел
                .Select(item => item.Split(',')) //сделай выборку таких элементов, для которых нужно разбить у учетом символа-разделителя - запятая
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) //сделай выборку из текущего массива такого, что 1я координата взята как 1й эл-т массива и конвертирована сразу в число
                .Where(e => e.x % 2 == 0) //проверка, такие пары, для которых - 1я координата четная
                .Select(point => (point.x * 10, point.y + 10)) //умножь 1ю координату на 10
                .ToArray(); //превратить в массив

for (int i = 0; i < data.Length; i++)
{
 Console.WriteLine(data[i]);
}

