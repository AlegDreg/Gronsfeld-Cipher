namespace Shifr
{
    internal interface IEncrtyption
    {
        /// <summary>
        /// Alphabet
        /// </summary>
        char[] Chars { get; }
        /// <summary>
        /// Decrypt text
        /// </summary>
        /// <param name="key">Message decrypt key</param>
        /// <param name="text">Message encrypted text</param>
        /// <returns>Decrypted text</returns>
        string Decrypt(int key, string text);
        /// <summary>
        /// Enctypt text
        /// </summary>
        /// <param name="key">Message encrypt key</param>
        /// <param name="text">Message text</param>
        /// <returns>Enctypted text</returns>
        string Encrypt(int key, string text);
    }
}
