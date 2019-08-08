using System;

public static class RotationalCipher
{
    const int AlphabetCount = 26;

    public static string Rotate(string text, int shiftKey)
    {       
        var array = text.ToCharArray();
        for (int i = 0; i < array.Length; i++)
        {
            var character = array[i];
            if(!char.IsLetter(character)) continue;

            var characterOffset = char.IsLower(character) ? 'a' : 'A';
            
            character = (char) (((character + shiftKey - characterOffset) % AlphabetCount) + characterOffset);
            array[i] = character;
        }
        return new string(array);
    }
}