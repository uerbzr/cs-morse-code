using exercise.morseengine.core;
using System.Diagnostics.Metrics;

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

    [Test]
    public void CheckSentence()
    {
        string acatishere =
            ". -"
            + new string(' ', 7) +
            "- . -"
            + new string(' ', 3) +
            ". -"
            + new string(' ', 3) +
            "-";
            
            

        MorseCodeEngine engine = new MorseCodeEngine();
        string cipher = ". -";
        
        Assert.IsTrue(engine.ValidateCipher(cipher));
        Assert.IsTrue(engine.IsSentenceCipher(acatishere));


    }
    [TestCase('A', ". -")]
    [TestCase('B', "- . . .")]
    [TestCase('C', "- . - .")]
    [TestCase('D', "- . .")]
    [TestCase('E', ".")]
    [TestCase('F', ". . - .")]
    [TestCase('G', "- - .")]
    [TestCase('H', ". . . .")]
    [TestCase('I', ". .")]
    [TestCase('J', ". - - -")]
    [TestCase('K', "- . -")]
    [TestCase('L', ". - . .")]
    [TestCase('M', "- -")]
    [TestCase('N', "- .")]
    [TestCase('O', "- - -")]
    [TestCase('P', ". - - .")]
    [TestCase('Q', "- - . -")]
    [TestCase('R', ". - .")]
    [TestCase('S', ". . .")]
    [TestCase('T', "-")]
    [TestCase('U', ". . -")]
    [TestCase('V', ". . . -")]
    [TestCase('W', ". - -")]
    [TestCase('X', "- . . -")]
    [TestCase('Y', "- . - -")]
    [TestCase('Z', "- - . .")]
    public void MorseValidateLetter(char letter, string cipher)
    {
        MorseCodeEngine engine = new MorseCodeEngine();
        var result = engine.Decode(cipher);
        Assert.That(letter.ToString(), Is.EqualTo(result));

    }
    
    [TestCase("The quick brown fox jumps over a lazy dog")]
    public void MessageIsSentence(string text)
    {
        MorseCodeEngine engine = new MorseCodeEngine();
        var result = engine.IsSentence(text);
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

   

    [Test]
    public void MorseTestLetterA()
    {
        MorseCodeEngine engine = new MorseCodeEngine();
        var result = engine.Encode("A");
        Assert.That("A", Is.EqualTo(result));

    }
    */
}