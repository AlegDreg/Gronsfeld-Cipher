using System;

namespace Shifr
{
    internal class Program
    {
        private static readonly char[] chars = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и',
                'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ',
                'ы', 'ь', 'э', 'ю', 'я', ' '};

        static void Main(string[] args)
        {
            int key = 187523;
            string value = "Зашифровать данный текст с помощью шифра Гронсфельда";

            Console.WriteLine("Оригинал - " + value + ". Ключ - " + key + "\n");

            IEncrtyption encrtyption = new GronsfeldChiper(chars);

            var enc = encrtyption.Encrypt(key, value);
            var dec = encrtyption.Decrypt(key, enc);


            Console.WriteLine("Зашифрованное - " + enc);
            Console.WriteLine("Расшифрованное - " + dec);
            Console.ReadKey();
        }
    }
}
