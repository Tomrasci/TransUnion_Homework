namespace Caesar_Cipher
{
    public class CaesarCipher
    {


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

        public string Decrypt(string value, int shift)
        {
            return new string(Encrypt(value, shift * (-1)));
        }

    }
}
