using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> _scores = new List<int>();

    public HighScores(List<int> list)
    {
        _scores = list;
    }

    public List<int> Scores() => _scores.ToList();

    public int Latest() => _scores.Last();

    public int PersonalBest() => _scores.Max();

    public List<int> PersonalTopThree() 
        => _scores.OrderByDescending(x => x).Take(3).ToList();
}