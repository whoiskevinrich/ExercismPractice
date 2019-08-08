using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    private static char[] _nucleotides = new[] {'A', 'C', 'G', 'T'};
    public static IDictionary<char, int> Count(string sequence)
    {
        if(ContainsInvalidNucleotides(sequence))
            throw new ArgumentException(nameof(sequence));

        return _nucleotides.ToDictionary(
            nucleotide => nucleotide, 
            nucleotide => sequence.ToCharArray().Count(seq => seq == nucleotide));
    }

    private static bool ContainsInvalidNucleotides(string sequence) 
        => !sequence.ToCharArray().All(nucleotide => _nucleotides.Contains(nucleotide));
}