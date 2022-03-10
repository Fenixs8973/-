using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Шифровщик
{
    class Encryption
    {
        static Form1 form = new Form1();
        static public string EnteredText;
        public int hut;

        public int FirstKey;
        public int SecondKey;
        //Ключи получает

        public void Rut()
        {
            EnteredText = EnteredText.ToUpper();
            string alph = "?!-.,АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";//алфавит
            char[] Alphabet = alph.ToCharArray();//Заполенение массива алфвитом
            char[] EnteredTextInArray = EnteredText.ToCharArray();//Введенный текст в виде массива
            char[] DecryptedText = new char[EnteredTextInArray.Length];//Дешифрованный текст

            int DecryptionLetterInt;
            char DecryptionLetterChar;
            int Index = 0;

            foreach (char VerifiableLetter in EnteredTextInArray)
            {
                //в цикл заходит

                if (VerifiableLetter != ' ')
                {

                    for (int i = 0; i < alph.Length; i++)//Ищем соответствие букв
                    {
                        if (Alphabet[i] == VerifiableLetter)
                        {
                            if(hut == 1)
                                DecryptionLetter(i, FirstKey, SecondKey, alph, out DecryptionLetterInt);//Нашли числовое значение буквы
                            else
                                EncryptionLetter(i, FirstKey, SecondKey, alph, out DecryptionLetterInt);//Нашли числовое значение буквы

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
            string EncryptionText = "";
            foreach (char tyh in DecryptedText)//Вывод
            {
                EncryptionText = EncryptionText + tyh;
            }
            MessageBox.Show(EncryptionText);

        }
        
        void DecryptionLetter(int i, int FirstKey, int SecondKey, string alph, out int DecryptionLetterInt)
        {
            DecryptionLetterInt = (i - SecondKey);
            while (DecryptionLetterInt % FirstKey != 0)
            {
                DecryptionLetterInt += alph.Length;
            }
            DecryptionLetterInt /= FirstKey;
        }

        void EncryptionLetter(int i, int FirstKey, int SecondKey, string alph, out int EncryptionLetterInt)
        {
            EncryptionLetterInt = FirstKey * i + SecondKey;
            while (EncryptionLetterInt > alph.Length)
            {
                EncryptionLetterInt -= alph.Length;
            }
        }

    }
        
   
}
