using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Шифровщик
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void Cryption()
        {
            Form1 form = new Form1();
            string EnteredText = Console.ReadLine();
            EnteredText = EnteredText.ToUpper();

            int FirstKey = Convert.ToInt32(Console.ReadLine());

            int SecondKey = Convert.ToInt32(Console.ReadLine());

            string alph = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";//алфавит
            char[] Alphabet = alph.ToCharArray();//Заполенение массива алфвитом
            char[] EnteredTextInArray = EnteredText.ToCharArray();//Введенный текст в виде массива
            char[] DecryptedText = new char[EnteredTextInArray.Length];//Дешифрованный текст

            int DecryptionLetterInt;
            char DecryptionLetterChar;
            int Index = 0;


            foreach (char VerifiableLetter in EnteredTextInArray)
            {
                if (VerifiableLetter != ' ')
                {
                    for (int i = 0; i < 33; i++)//Ищем соответствие букв
                    {
                        if (Alphabet[i] == VerifiableLetter)
                        {
                            DecryptionLetter(i, FirstKey, SecondKey, out DecryptionLetterInt);//Нашли числовое значение буквы
                            DecryptionLetterChar = Alphabet[DecryptionLetterInt];//Нашли буквенное значение цифры
                            DecryptedText[Index] = DecryptionLetterChar;//Записали букву в массив
                            Index++;
                            break;
                        }
                    }
                }
                else
                {
                    DecryptedText[Index] = ' ';
                    Index++;
                }

            }
            foreach (char tyh in DecryptedText)//Вывод
            {
                Console.Write(tyh);
            }
        }
        static void DecryptionLetter(int i, int FirstKey, int SecondKey, out int DecryptionLetterInt)
        {

            DecryptionLetterInt = (i - SecondKey);
            while (DecryptionLetterInt % FirstKey != 0)
            {
                DecryptionLetterInt += 33;
            }
            DecryptionLetterInt /= FirstKey;
        }
    }
}
