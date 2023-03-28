// Написать программу, которая из имеющегося массива сторок формирует массив из строк, длина которых меньше либо равна 3 символа.

Console.Clear();

string[] strings = { "hello", "world", "2", "work", "88", ":)" }; 
var result = strings.Where(s => s.Length <= 3).ToArray(); 
Console.WriteLine(string.Join(", ", result)); 
Console.ReadLine();