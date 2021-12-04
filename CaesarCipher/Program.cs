using System;

namespace Caesar_Cipher
{
    class Program
    {
         static void Main(string[] args)
         {
            CaesarCipher cipher = new CaesarCipher();
            try {
            System.Console.WriteLine("Please input a string to encrypt");
            string inputString = Console.ReadLine();
            System.Console.WriteLine("Please input the shift number");
            int shift = Convert.ToInt32(Console.ReadLine());
            
            string encryptedMessage = cipher.Encrypt(inputString, shift);
            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Encrypted message: " + encryptedMessage);
            string decryptedMessage = cipher.Decrypt(encryptedMessage, shift);
            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Decrypted message: " + decryptedMessage);
            System.Console.WriteLine("--------------------------------------");
            }
            catch (System.FormatException){
            System.Console.WriteLine("Shift number must be a whole number");
            }

         }
    }
}
