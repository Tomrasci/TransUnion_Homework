namespace Caesar_Cipher
{
    public class CaesarCipher
    {
        const int alphabetNumber = 26;

        /// <summary>
        /// Method to encrypt a given string, shifting the letters by a given number. If it's not letter characters, it ignores them.
        /// </summary>
        /// <param name="input">Given string input to encrypt</param>
        /// <param name="shift">Given number by how many letters should every given string letter be shifted</param>
        /// <returns>"Encrypted string</returns>
        public string Encrypt(string input, int shift)
        {
            bool isUpperLetter = false;
            bool isAlphabetLetter = false;
            char[] letterArray = input.ToCharArray();

            for (int i = 0; i < letterArray.Length; i++)
            {
                char letter = letterArray[i];
                isAlphabetLetter = char.IsLetter(letter);
                isUpperLetter = char.IsUpper(letter);

                if (isAlphabetLetter)
                {
                    letter = (char)(letter + shift % alphabetNumber);
                    if (isUpperLetter)
                    {
                        letter = upperCaseLetterCheck(letter);
                    }
                    else
                    {
                        letter = lowerCaseLetterCheck(letter);
                    }
                    letterArray[i] = letter;
                }
            }
            return new string(letterArray);
        }
        /// <summary>
        /// Method to decrypt the given string, uses same encrypt method but shifts to the other side.
        /// </summary>
        /// <param name="value">Given string input to encrypt</param>
        /// <param name="shift">Given number by how many letters should every given string letter be shifted</param>
        /// <returns>Decrypted string</returns>
        public string Decrypt(string value, int shift)
        {
            return new string(Encrypt(value, shift * (-1)));
        }
        /// <summary>
        /// Checks whether the lowerCase letter is out of alphabet bounds
        /// </summary>
        /// <param name="letter"></param>
        /// <returns>Modified or same letter</returns>
        public char lowerCaseLetterCheck(char letter)
        {
            if (letter < 'a')
            {
                letter = (char)(letter + alphabetNumber);
            }
            else if (letter > 'z')
            {

                letter = (char)(letter - alphabetNumber);
            }
            return letter;
        }
        /// <summary>
        ///  Checks whether the upperCase letter is out of alphabet bounds
        /// </summary>
        /// <param name="letter"></param>
        /// <returns>Modified or same letter</returns>
        public char upperCaseLetterCheck(char letter)
        {
            if (letter < 'A')
            {
                letter = (char)(letter + alphabetNumber);
            }
            else if (letter > 'Z')
            {

                letter = (char)(letter - alphabetNumber);
            }
            return letter;
        }

    }
}
