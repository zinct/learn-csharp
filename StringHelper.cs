using System;

public static class StringHelper {

    /// <summary>
    /// Convert the first letter of word to uppercase
    /// </summary>
    public static string FirstUpperCase(this string word) {

        // Convert from string to Char[]
        char[] seperateLetters = word.Trim().ToCharArray();

        // Check if letter is not null
        if(seperateLetters.Length > 0) {
            // Change first letter to uppercase
            seperateLetters[0] = Char.ToUpper(seperateLetters[0]);
            // Check if the letter have some whitespace
            for(int i = 0; i < seperateLetters.Length; i++) {
                if(Char.IsSeparator(seperateLetters[i])) {
                    // Convert next from whitespace to uppercase
                    seperateLetters[i + 1] = Char.ToUpper(seperateLetters[i + 1]);
                }
            }
        }
        
        return new string(seperateLetters);
    }
}