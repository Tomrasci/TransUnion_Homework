using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caesar_Cipher;
namespace CaesarCipherTest
{
    [TestClass]
    public class CaesarCipherTest
    {
        /// <summary>
        /// Method to test whether the cipher works with upperCase letters
        /// </summary>
        [TestMethod]
        public void TestWithUpperCaseLettersEncrypt()
        {
            string input = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            int shift = 3;
            string desiredOutput = "WKH TXLFN EURZQ IRA MXPSV RYHU WKH ODCB GRJ";
            CaesarCipher cipher = new CaesarCipher();
            Assert.AreEqual(desiredOutput, cipher.Encrypt(input, shift));
        }
        /// <summary>
        /// Method to test whether the cipher works with lowerCase letters
        /// </summary>
        [TestMethod]
        public void TestWithLowerCaseLettersEncrypt()
        {
            string input = "abcdefghijklmnopqrstuvwqz";
            int shift = 3;
            string desiredOutput = "defghijklmnopqrstuvwxyztc";
            CaesarCipher cipher = new CaesarCipher();
            Assert.AreEqual(desiredOutput, cipher.Encrypt(input, shift));
        }
        /// <summary>
        /// Method to test if the cipher doesn't do anything with non letter characters.
        /// </summary>
        [TestMethod]
        public void TestAllNonLetterCharacters()
        {
            string input = "12452_%$#!";
            int shift = 3;
            CaesarCipher cipher = new CaesarCipher();
            Assert.AreEqual(input, cipher.Encrypt(input, shift));
        }
        /// <summary>
        /// Method to test if the module formula works on the shift (shifting by 26 and 104 should produce same result)
        /// </summary>
        [TestMethod]
        public void TestWithLargeShift()
        {
            string input = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            int shift = 26;
            int largeShift = 104;
            CaesarCipher cipher = new CaesarCipher();
            Assert.AreEqual(cipher.Encrypt(input, shift), cipher.Encrypt(input, largeShift));
        }
        /// <summary>
        /// Method to test whether the cipher works with upperCase letters when decrypting
        /// </summary>
        [TestMethod]
        public void TestWithUpperCaseLettersDecrypt()
        {
            string input = "WKH TXLFN EURZQ IRA MXPSV RYHU WKH ODCB GRJ";
            string desiredOutput = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            int shift = 3;
            CaesarCipher cipher = new CaesarCipher();
            Assert.AreEqual(desiredOutput, cipher.Decrypt(input, shift));
        }
        /// <summary>
        /// Method to test whether the cipher works with lowerCase letters when decrypting
        /// </summary>
        [TestMethod]
        public void TestWithLowerCaseLettersDecrypt()
        {
            string input = "defghijklmnopqrstuvwxyztc";
            int shift = 3;
            string desiredOutput = "abcdefghijklmnopqrstuvwqz";
            CaesarCipher cipher = new CaesarCipher();
            Assert.AreEqual(desiredOutput, cipher.Decrypt(input, shift));
        }
    }
}
