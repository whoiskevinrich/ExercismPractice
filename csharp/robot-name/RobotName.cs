using System;
using System.Collections.Generic;
using System.Linq;

public class Robot
{
    private string _name;
    private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    
    private static List<string> NamesInUse = new List<string>();
    private readonly Random _random = new Random();


    public Robot() => Reset();

    public string Name => _name;

    private string RandomString(int length) => 
        new string(Enumerable.Repeat(chars, length)
            .Select(str => chars[_random.Next(str.Length)])
                .ToArray());

    private int RandomNumber(int min, int max) => _random.Next(min, max);

    public void Reset()
    {
        do
        {
            _name = $"{RandomString(2)}{RandomNumber(0,999):000}";
        } while (NamesInUse.Contains(_name));
        NamesInUse.Add(_name);
    }
}