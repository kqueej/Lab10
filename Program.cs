// Step 2 and 3
// class Program
// {
//     static void Main()
//     {
//         string text = "  Строки в C# неизменяемы  ";

//         Console.WriteLine($"Length text: {text.Length}");
//         string clean = text.Trim();
//         Console.WriteLine($"Without spaces: {text.Trim()}");
//         Console.WriteLine($"Length clean: {clean.Length}");
//         Console.WriteLine($"First char: {clean[0]}");
//         Console.WriteLine($"Last char: {clean[clean.Length - 1]}");
//         Console.WriteLine($"Upper: {clean.ToUpper()}");


//         Console.WriteLine($"Include \"C#\": {clean.Contains("C#")}");
//         Console.WriteLine($"Include \"c#\": {clean.Contains("c#")}");
//         Console.WriteLine($"Position \"C#\": {clean.IndexOf("C#")}");
//         string changed = clean.Replace("неизменяемы", "удобны");
//         Console.WriteLine(changed);


//         // Строка НЕ изменилась, ToUpper() создал новую строку и вернул её, но мы то результат не сохранили
//         clean.ToUpper();
//         Console.WriteLine(clean);
//     }
// }

// Step 4
// class Program
// {
//     static void Main()
//     {
//         string date = "15.09.2025";

//         string day = date.Substring(0, 2);
//         string month = date.Substring(3, 2);
//         string year = date.Substring(6, 4);

//         Console.WriteLine(day);
//         Console.WriteLine(month);
//         Console.WriteLine(year);
//     }
// }

// Step 5
// class Program
// {
//     static void Main()
//     {
//         string line = "Иванов,25,Программист";

//         string[] parts = line.Split(',');
//         Console.WriteLine($"Count of parts: {parts.Length}");

//         for (int i = 0; i < parts.Length; i++)
//         {
//             Console.WriteLine($"{i}: {parts[i]}");
//         }

//         Console.WriteLine( $"{parts[0]}, {parts[1]} лет, {parts[2]}");
//     }
// }

// Step 6
// class Program
// {
//     static void Main()
//     {
//         string sentence = "  Сегодня   хорошая   погода  ";
//         string[] wordsWithEmpty = sentence.Split(' ');

//         Console.WriteLine($"Without RemoveEmptyEntries: {wordsWithEmpty.Length}");

//         string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

//         Console.WriteLine($"With RemoveEmptyEntries: {words.Length}");

//         foreach (string word in words)
//         {
//             Console.WriteLine(word);
//         }

        /*
        Потому что Split возвращает массив string[]
        А с массивами мы уже умеем работать и получать Length, обращаться по индексам,
        использовать for и foreach.
        */
//     }
// }

// Step 7
class Program
{
    static void Main()
    {
        string? text;
        while (true)
        {
            Console.Write("Enter line: ");
            text = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(text))
            {
                break;
            }
            Console.WriteLine("Error: line cannot ne empty");
        }

        string clean = text.Trim();

        string lower = clean.ToLower();

        bool containsCode = lower.Contains("код");
        bool startsWithHello = lower.StartsWith("привет");
        bool endsWithExclamation = clean.EndsWith("!");

        Console.WriteLine($"Include word \"код\": {(containsCode ? "true" : "false")}");
        Console.WriteLine($"Start with \"Привет\": {(startsWithHello ? "true" : "false")}");
        Console.WriteLine($"End with \"!\": {(endsWithExclamation ? "true" : "false")}");
    }
}

