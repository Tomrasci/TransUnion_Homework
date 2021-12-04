namespace Caesar_Cipher
{
    public class CaesarCipher
    {
        /// <summary>
        /// Method to encrypt a given string, shifting the letters by a given number. If it's not letter characters, it ignores them.
        /// </summary>
        /// <param name="input">Given string input to encrypt</param>
        /// <param name="shift">Given number by how many letters should every given string letter be shifted</param>
        /// <returns></returns>
            public string Encrypt(string input, int shift)
        {
            bool isUpper = false;
            bool isLetter = false;
            char[] letterArray = input.ToCharArray();

            for (int i = 0; i < letterArray.Length; i++)
            {
                char letter = letterArray[i];
                isUpper = char.IsUpper(letter);

                isLetter = char.IsLetter(letter);

                if (isLetter)
                {
                    letter = (char)(letter + shift % 26);
                    if (isUpper)
                    {
                        if (letter < 'A')
                        {
                            letter = (char)(letter + 26);
                        }
                        else if (letter > 'Z')
                        {

                            letter = (char)(letter - 26);
                        }
                    }
                    else
                    {
                        if (letter < 'a')
                        {
                            letter = (char)(letter + 26);
                        }
                        else if (letter > 'z')
                        {

                            letter = (char)(letter - 26);
                        }
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
        /// <returns></returns>
            public string Decrypt(string value, int shift)
        {
            return new string(Encrypt(value, shift * (-1)));
        }
    }
}