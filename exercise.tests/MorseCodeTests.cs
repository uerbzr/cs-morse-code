using exercise.morseengine;

namespace exercise.tests;

public class Tests
{
    
   
    [Test]
    public void MorseEncodeCAB()
    {

        MorseCodeEngine engine = new MorseCodeEngine();
        string cipher = ". -";
        var result = engine.ValidateCipher(cipher);
        Assert.IsTrue(result);

    }



    /*

    [Test]
    public void MorseDecodeCAB()
    {
        string cipher = "- . - .   . -   - . . .";
        MorseCodeEngine engine = new MorseCodeEngine();
        var result = engine.Decode(cipher);
        Assert.That(cipher, Is.EqualTo(result));

    }

    [TestCase('A', ". -")]
    public void MorseValidateLetter(char letter, string cipher)
    {
        MorseCodeEngine engine = new MorseCodeEngine();        
        var result = engine.Decode(cipher);
        Assert.That(letter.ToString(), Is.EqualTo(result));

    }

    [Test]
    public void MorseTestLetterA()
    {
        MorseCodeEngine engine = new MorseCodeEngine();
        var result = engine.Encode("A");
        Assert.That("A", Is.EqualTo(result));

    }
    */
}