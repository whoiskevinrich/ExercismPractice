using System;

public static class ResistorColor
{

    public static int ColorCode(string color)
    {
        var colors = Colors();
        for(int i = 0; i < colors.Length; i++)
        {
            if(color.ToLowerInvariant() == colors[i]) return i;
        }

        throw new ArgumentException(nameof(color), "not valid");     
    }

    public static string[] Colors() =>
        new []
        {
            "black",
            "brown",
            "red",
            "orange",
            "yellow",
            "green",
            "blue",
            "violet",
            "grey",
            "white"
        };
}