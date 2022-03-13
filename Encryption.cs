using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public void Rut()
        {
            EnteredText = EnteredText.ToUpper();
            string alph = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";//алфавит
            char[] Alphabet = alph.ToCharArray();//Заполенение массива алфвитом
            char[] CryptedText = new char[100];
            Regex regex = new Regex(@"\w*\S?", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(EnteredText);

            string[] Text = new string[EnteredText.Length];
            string EndText = null;

            int CryptionLetterInt;
            char CryptionLetterChar;
            int Index = 0;

            foreach (Match match in matches)//Все слова
            {
                string g = match.Value;
                char[] c = g.ToCharArray();
                string Letter = null;
                foreach (char u in c)
                {
                    switch (u)
                    {
                        case ' ':
                            Letter += "";
                            break;
                        case '.':
                            Letter += ".";
                            break;
                        case ',':
                            Letter += ",";
                            break;
                        case '-':
                            Letter += "-";
                            break;
                        case '!':
                            Letter += "!";
                            break;
                        case '?':
                            Letter += "?";
                            break;
                        default:
                            for (int i = 0; i < 33; i++)//Ищем соответствие букв
                            {
                                if (Alphabet[i] == u)
                                {
                                    if (hut == 1)
                                    {
                                        DecryptionLetter(i, FirstKey, SecondKey, out CryptionLetterInt);//Нашли числовое значение буквы
                                    }
                                    else
                                    {
                                        EncryptionLetter(i, FirstKey, SecondKey, out CryptionLetterInt);//Нашли числовое значение буквы
                                    }

                                    CryptionLetterChar = Alphabet[CryptionLetterInt];//Нашли буквенное значение цифры
                                    CryptedText[Index] = CryptionLetterChar;//Записали букву в массив
                                    Letter += Convert.ToString(CryptedText[Index]);
                                    Index++;                                //Index++;

                                }
                            }
                            break;
                    }


                    
                }
                if (Letter != null)
                {
                    Letter += " ";
                }
                EndText += Letter;
                Index = 0;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(EndText);
                streamWriter.Close();
            }

            void DecryptionLetter(int i, int FirstKey, int SecondKey, out int DecryptionLetterInt)
            {
                DecryptionLetterInt = (i - SecondKey);
                while (DecryptionLetterInt % FirstKey != 0)
                {
                    DecryptionLetterInt += 33;
                }
                DecryptionLetterInt /= FirstKey;
            }

            void EncryptionLetter(int i, int FirstKey, int SecondKey, out int EncryptionLetterInt)
            {
                EncryptionLetterInt = FirstKey * i + SecondKey;
                while (EncryptionLetterInt >= 33)
                {
                    EncryptionLetterInt -= 33;
                }
            }
        }
    }
}
