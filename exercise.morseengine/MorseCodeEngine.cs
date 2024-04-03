namespace exercise.morseengine;

public class MorseCodeEngine
{
    private Dictionary<char, string> _morse = new Dictionary<char, string>()
    {
        { 'A',". -" },
        { 'B',"- . . ."},
        { 'C',"- . - ."},
        { 'D',""},
        { 'E',""},
        { 'F',""},
        { 'G',""},
        { 'I',""},
        { 'J',""},
        { 'K',""},
        { 'L',""},
        { 'M',""},
        { 'N',""},
        { 'O',""},
        { 'P',""},
        { 'Q',""},
        { 'R',""},
        { 'S',""},
        { 'T',""},
        { 'U',""},
        { 'V',""},
        { 'W',""},
        { 'X',""},
        { 'Y',""},
        { 'Z',""}

    };
    public string Encode(string message)
    {
        string result = string.Empty;



        return string.Empty;
    }
    public string Decode(string cipher)
    {
        return string.Empty;
    }
    public bool ValidateCipher(string cipher)
    {

        if (_morse.ContainsValue(cipher)) return true; //single letter cipher
        
        return false;

    }
    public bool IsSentance(string cipher)
    {
        cipher.Contains()
        return false;
    }

}
