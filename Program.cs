#pragma warning disable
using System.Text.RegularExpressions;

// задание 1
//// a)
//Console.WriteLine("Введите строку:");
//string str = Console.ReadLine();
//Regex r = new Regex(@"abcd(2023)1{7}0\1");
//if (r.IsMatch(str))
//    Console.WriteLine("Строка содержит \"abcd2023111111102023\"");
//else 
//    Console.WriteLine("Строка не содержит \"abcd2023111111102023\"");
//Regex new_r = new Regex(@"2023");
//string extra = " happy new year ";
//string changed_str = new_r.Replace(str, extra);
//Console.WriteLine("Измененная строка: " + changed_str);

//// b)
//Regex num_r = new(@"\d+");
//MatchCollection mathces = num_r.Matches(str);
//List<long> nums = new();
//foreach (Match m in mathces)
//    nums.Add(Convert.ToInt64(m.Value));
//Console.Write("Полученные числа: ");
//long sum = 0;
//int max_ind = 0;
//for (int i = 0; i < nums.Count; i++)
//{
//    Console.Write(nums[i] + " ");
//    sum += nums[i];
//    if (nums[i] > nums[max_ind]) max_ind = i;
//}
//Console.WriteLine("Их сумма = " + sum);
//Console.WriteLine("Максимальное число = " + nums[max_ind] + ", его индекс = " + max_ind);

//// c)
//string pattern = @"[-+]?\d+([.,]\d+)?";
//string replacement = "number";
//MatchCollection matches = Regex.Matches(str, pattern);
//Console.Write("Массив чисел: ");
//foreach (Match m in matches)
//    Console.Write(m.Value + " ");
//Console.Write("\nИзмененная строка: ");
//string result = Regex.Replace(str, pattern, replacement);
//Console.WriteLine(result);

//// d)
//string path = @"C:\Users/Kristina\university\exam.csv";
//pattern = @"(?<=\\|\/)[^\\/:*?""<>|.]+(?=\\|\/|$)";
//matches = Regex.Matches(path, pattern);
//Console.WriteLine("Имена всех каталогов:");
//foreach (Match m in matches)
//    Console.WriteLine(m.Value);


// задание 2
// a)
string[] strings = new string[5];
for (int i = 0; i < strings.Length; i++)
{
    Console.Write("Введите строку: ");
    strings[i] = Console.ReadLine();
}
Regex reg = new("cat");
Console.WriteLine("Строки, содержащие cat 2 раза");
foreach (string s in strings)
{
    if (reg.Matches(s).Count == 2)
        Console.WriteLine(s);
}

// b)
strings = new string[]{
    "This is a string with words longer than 10 characters, like elephant, hippopotamus",
    "Another string with words like antidisestablishmentarianism, supercalifragilisticexpialidocious",
    "Short string",
    "And another long string with even longer words like pneumonoultramicroscopicsilicovolcanoconiosis"
};
string pattern = @"\b\w{10,}\b";
foreach (string s in strings)
{
    Console.WriteLine(s);
    string newstr = Regex.Replace(s, pattern, "*");
    Console.WriteLine("Result 1: " + newstr);
    newstr = Regex.Replace(s, pattern, m => m.Value[0].ToString());
    Console.WriteLine("Result 2: " + newstr);
    newstr = Regex.Replace(s, pattern, m => m.Value.Substring(0, Math.Min(m.Value.Length, 3)));
    Console.WriteLine("Result 3: " + newstr + '\n');
}

// c)
string[] lines = new string[5];
Console.WriteLine("Введите 5 строк:");
for (int i = 0; i < 5; i++)
{
    lines[i] = Console.ReadLine();
    lines[i] = Regex.Replace(lines[i], @"ик(\b|$)", "");
}
Console.WriteLine("Результат:");
foreach (string line in lines)
{
    Console.WriteLine(line);
}

// d)
Console.WriteLine("Введите идентификатор цвета в HTML:");
string input = Console.ReadLine();
bool isHtmlColor = Regex.IsMatch(input, "^#[0-9A-Fa-f]{6}$");
if (isHtmlColor)
{
    Console.WriteLine("Данная строка является шестнадцатиричным идентификатором цвета в HTML.");
}
else
{
    Console.WriteLine("Данная строка не является шестнадцатиричным идентификатором цвета в HTML.");
}

// e)
Console.WriteLine("Введите строку для проверки:");
input = Console.ReadLine();
bool isGuid = Regex.IsMatch(input, "^[0-9A-Fa-f]{8}-[0-9A-Fa-f]{4}-[0-9A-Fa-f]{4}-[0-9A-Fa-f]{4}-[0-9A-Fa-f]{12}$");
if (isGuid)
{
    Console.WriteLine("Данная строка является GUID.");
}
else
{
    Console.WriteLine("Данная строка не является GUID.");
}
