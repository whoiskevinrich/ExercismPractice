using System;
using System.Collections.Generic;
using System.Linq;

public static class MatchingBrackets
{
    private static char[] brackets = new[]{'(',')','[',']','{','}'};

    public static bool IsPaired(string input)
    {
        var inputBrackets = GetBracketsFrom(input);
        if(string.IsNullOrWhiteSpace(input)) return true;

        var anyUnpairedBracketCharacters = inputBrackets.Count() % 2 == 1;
        if(anyUnpairedBracketCharacters) return false;

        var referenceCharacterArrayLocation = Array.IndexOf(brackets, inputBrackets.First());
        var firstCharacterIsOpeningBracket = referenceCharacterArrayLocation % 2 == 0;
        
        if(!firstCharacterIsOpeningBracket) return false;
        var firstAndLastMatch =  inputBrackets.Last() == brackets[referenceCharacterArrayLocation + 1];
        
        var inner = input.Substring(1,input.Length - 2);
        return firstAndLastMatch && IsPaired(inner);
    }

    private static IEnumerable<char> GetBracketsFrom(string input) => input.Where(x => brackets.Contains(x));
}
