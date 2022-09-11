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
        /// <param name="key">Message decrypt key. Only numerics</param>
        /// <param name="text">Message encrypted text</param>
        /// <returns>Decrypted text</returns>
        string Decrypt(string key, string text);
        /// <summary>
        /// Enctypt text
        /// </summary>
        /// <param name="key">Message encrypt key. Only numerics</param>
        /// <param name="text">Message text</param>
        /// <returns>Enctypted text</returns>
        string Encrypt(string key, string text);
    }
}
