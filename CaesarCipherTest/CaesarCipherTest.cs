using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caesar_Cipher;
namespace CaesarCipherTest
{
    [TestClass]
    public class CaesarCipherTest
    {
        [TestMethod]
        public void TestWithUpperCaseLettersEncrypt()
        {
            string input = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            int shift = 3;
            string desiredOutput = "WKH TXLFN EURZQ IRA MXPSV RYHU WKH ODCB GRJ";
            CaesarCipher cipher = new CaesarCipher();
            Assert.AreEqual(cipher.Encrypt(input, shift), desiredOutput);
        }

        [TestMethod]
        public void TestWithLowerCaseLettersEncrypt()
        {
            string input = "abcdefghijklmnopqrstuvwqz";
            int shift = 3;
            string desiredOutput = "defghijklmnopqrstuvwxyztc";
            CaesarCipher cipher = new CaesarCipher();
            Assert.AreEqual(cipher.Encrypt(input, shift), desiredOutput);
        }

        [TestMethod]
        public void TestAllNonLetterCharacters()
        {
            string input = "12452_%$#!";
            int shift = 3;
            CaesarCipher cipher = new CaesarCipher();
            Assert.AreEqual(cipher.Encrypt(input, shift), input);
        }

        [TestMethod]
        public void TestWithLargeShift()
        {
            string input = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            int shift = 26;
            int largeShift = 104;
            CaesarCipher cipher = new CaesarCipher();
            Assert.AreEqual(cipher.Encrypt(input, shift), cipher.Encrypt(input, largeShift));
        }

        [TestMethod]
        public void TestWithUpperCaseLettersDecrypt()
        {
            string input = "WKH TXLFN EURZQ IRA MXPSV RYHU WKH ODCB GRJ";
            string desiredOutput = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            int shift = 3;
            CaesarCipher cipher = new CaesarCipher();
            Assert.AreEqual(cipher.Decrypt(input, shift), desiredOutput);
        }
          [TestMethod]
        public void TestWithLowerCaseLettersDecrypt()
        {
            string input = "defghijklmnopqrstuvwxyztc";
            int shift = 3;
            string desiredOutput = "abcdefghijklmnopqrstuvwqz";
            CaesarCipher cipher = new CaesarCipher();
            Assert.AreEqual(cipher.Decrypt(input, shift), desiredOutput);
        }
    }
}
