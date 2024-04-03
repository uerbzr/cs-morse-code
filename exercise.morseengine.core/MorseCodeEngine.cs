using System.Reflection.Metadata.Ecma335;

namespace exercise.morseengine.core;

public class MorseCodeEngine
{
    private Dictionary<char, string> _morse = new Dictionary<char, string>()
    {
        { 'A',". -" },
        { 'B',"- . . ."},
        { 'C',"- . - ."},
        { 'D',"- . ."},
        { 'E',"."},
        { 'F',". . - ."},
        { 'G',"- - ."},
        { 'I',". ."},
        { 'H',". . . ."},
        { 'J',". - - -"},
        { 'K',"- . -"},
        { 'L',". - . ."},
        { 'M',"- -"},
        { 'N',"- ."},
        { 'O',"- - -"},
        { 'P',". - - ."},
        { 'Q',"- - . -"},
        { 'R',". - ."},
        { 'S',". . ."},
        { 'T',"-"},
        { 'U',". . -"},
        { 'V',". . . -"},
        { 'W',". - -"},
        { 'X',"- . . -"},
        { 'Y',"- . - -"},
        { 'Z',"- - . ."}

    };
    public string Encode(string message)
    {
        string result = string.Empty;



        return string.Empty;
    }
    public string Decode(string cipher)
    {
        if(IsSingleLetterCipher(cipher))
        {
            return _morse.Where(x => x.Value==cipher).FirstOrDefault().Key.ToString();
        }
        return string.Empty;
    }
    public bool ValidateCipher(string cipher)
    {

        if (_morse.ContainsValue(cipher)) return true; //single letter cipher
        
        return false;

    
    }
    public bool IsSentence(string text) => text.Contains(' ') ? true : false;
    public bool IsSentenceCipher(string cipher) => cipher.Contains(new string(' ',7)) ? true : false;
    public bool IsSingleLetterCipher(string cipher) => !cipher.Contains(new string(' ', 3)) ? true : false;
}
