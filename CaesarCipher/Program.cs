using System;

namespace Caesar_Cipher
{
    class Program
    {
         static void Main(string[] args)
         {
            CaesarCipher cipher = new CaesarCipher();
            string testString = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            int shift = 3;
            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Message: " + testString);
            string encryptedMessage = cipher.Encrypt(testString, shift);
            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Encrypted message: " + encryptedMessage);
            string decryptedMessage = cipher.Decrypt(encryptedMessage, shift);
            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Decrypted message: " + decryptedMessage);
            System.Console.WriteLine("--------------------------------------");


         }
    }
}
