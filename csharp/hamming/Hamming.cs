using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if(firstStrand.Length != secondStrand.Length) 
            throw new ArgumentException("Strands must be the same length");

        var first = firstStrand.ToCharArray();
        var second = secondStrand.ToCharArray();

        var count = 0;

        for (int i = 0; i < first.Length; i++)
        {
            if(!char.Equals(first[i],second[i])) count++;
        }

        return count;
    }
}