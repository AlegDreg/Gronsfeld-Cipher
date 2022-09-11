using System;
using System.Text;

namespace Shifr
{
    internal class GronsfeldChiper : IEncrtyption
    {
        public char[] Chars { get; }
        internal GronsfeldChiper(char[] chars)
        {
            Chars = chars;
        }

        public string Decrypt(string key, string text)
        {
            text = text.ToLower();

            var res = new StringBuilder(text.Length);

            int currentKeyId = 0;

            for (int i = 0; i < text.Length; i++)
            {
                res.Append(
                    DecryptChar(
                        Convert.ToInt32(key[currentKeyId].ToString()),
                        text[i],
                    Chars));

                currentKeyId++;
                if (currentKeyId >= key.Length)
                {
                    currentKeyId = 0;
                }
            }

            return res.ToString();
        }

        private char DecryptChar(int keyChar, char messageChar, char[] chars)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == messageChar)
                {
                    if (i - keyChar < 0)
                    {
                        int v = chars.Length - (keyChar - i);

                        return chars[v];
                    }
                    else
                    {
                        return chars[i - keyChar];
                    }
                }
            }

            throw new Exception();
        }

        public string Encrypt(string key, string text)
        {
            text = text.ToLower();

            var res = new StringBuilder(text.Length);

            int currentKeyId = 0;

            for (int i = 0; i < text.Length; i++)
            {
                res.Append(
                    EncrtptChar(
                        Convert.ToInt32(key[currentKeyId].ToString()),
                        text[i], Chars));

                currentKeyId++;
                if (currentKeyId >= key.Length)
                {
                    currentKeyId = 0;
                }
            }

            return res.ToString();
        }

        private char EncrtptChar(int keyChar, char messageChar, char[] chars)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == messageChar)
                {
                    if (chars.Length <= i + keyChar)
                    {
                        int v = chars.Length - (keyChar + i);

                        if (v < 0)
                            v *= -1;

                        return chars[v];
                    }
                    else
                    {
                        return chars[i + keyChar];
                    }
                }
            }

            throw new Exception();
        }
    }
}