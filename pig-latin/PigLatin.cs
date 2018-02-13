using System.Text;

public static class PigLatin
{
    public static string Translate(string word)
    {
        string firstLetter = word.Substring(0, 1);
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        //string vowels = ("aeiou");
        string translation = "";


        foreach (char letter in vowels)
        {
            if (firstLetter == letter.ToString())
            {
                translation = word + "ay";
            }

            else if (word.IndexOf("xr") == 0 || word.IndexOf("yt") == 0)
            {
                translation = word + "ay";
            }
            else
            {
                //string secondLetter = word.Substring(1, 1);
                //secondLetter.IndexOfAny(vowels);
                int i = word.IndexOfAny(vowels, 1, 1);
                if (i == 1)
                {
                    // second letter is a vowel
                    string restOfWord = word.Substring(1);
                    translation = restOfWord + firstLetter + "ay";
                }
                else
                {
                    // if second letter is consonant
                }
            }
        }
        return translation;
    }
}
