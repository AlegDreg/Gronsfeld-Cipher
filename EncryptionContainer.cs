namespace Shifr
{
    internal class EncryptionContainer
    {
        private IEncrtyption Encrtyption;

        public EncryptionContainer(IEncrtyption encrtyption)
        {
            Encrtyption = encrtyption;
        }

        public string Encrypt(int key, string text)
        {
            return Encrtyption.Encrypt(key, text);
        }

        public string Decrypt(int key, string text)
        {
            return Encrtyption?.Decrypt(key, text);
        }
    }
}
