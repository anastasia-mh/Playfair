using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Playfair
{
    public partial class Form1 : Form
    {
        private int flag = 0;//0-ключ изначально не создан, 1 - ENG, 2 - RUS
        private string key_matrix = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void fillGrid(string s, int c)//заполнение ключевой матрицы
        {
            key_matrix = s;
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = c;
            dataGridView1.RowCount = c;
            for (int i = 0; i < s.Length; ++i)
            {
                dataGridView1.Rows[i / c].Cells[i % c].Value = s[i];
            }
        }

        private string cipher(char first, char second, int op, int c)//при op = 1 - шифрование, при op = -1 - дешифрование биграммы
        {
            string res_bigram = "";
            int a = key_matrix.IndexOf(first);
            int b = key_matrix.IndexOf(second);
            int a_row = a / c;
            int b_row = b / c;
            int a_column = a % c;
            int b_column = b % c;
            if (a_row == b_row)
            {
                res_bigram += dataGridView1.Rows[a_row].Cells[(a_column + 1 * op + c) % c].Value;//прибавляем размер таблицы чтобы не делать дополнительную проверку на отрицательные числа
                res_bigram += dataGridView1.Rows[b_row].Cells[(b_column + 1 * op + c) % c].Value;
            }
            else if (a_column == b_column)
            {
                res_bigram += dataGridView1.Rows[(a_row + 1 * op + c) % c].Cells[a_column].Value;
                res_bigram += dataGridView1.Rows[(b_row + 1 * op + c) % c].Cells[b_column].Value;
            }
            else
            {
                res_bigram += dataGridView1.Rows[a_row].Cells[b_column].Value;
                res_bigram += dataGridView1.Rows[b_row].Cells[a_column].Value;
            }
            return res_bigram;
        }

        private string encrypt(string s)//шифрование
        {
            int c = 5;
            string s_res = "";
            if (flag == 2)
                c = 6;
            if ((s.Length % 2 == 1) && (c == 5))
                s += "X";
            if ((s.Length % 2 == 1) && (c == 6))
                s += "Я";
            for (int i = 0; i < s.Length; i += 2)
            {
                if ((s[i] == s[i + 1]) && (c == 5))
                    s = s.Remove(i + 1, 1).Insert(i + 1, "X");
                if ((s[i] == s[i + 1]) && (c == 6))
                    s = s.Remove(i + 1, 1).Insert(i + 1, "Я");
                s_res += cipher(s[i], s[i+1], 1, c);
            }
            return s_res;
        }

        private string decrypt(string s)//дешифрование
        {
            int c = 5;
            string s_res = "";
            if (flag == 2)
                c = 6;
            for (int i = 0; i < s.Length; i += 2)
            {
                s_res += cipher(s[i], s[i + 1], -1, c);
            }

            return s_res;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string key = textBoxKey.Text.ToUpper();
            string sENG = "ABCDEFGHIKLMNOPQRSTUVWXYZ";//J == I
            string sRUS = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ .,";
            
            if (radioButtonENG.Checked)
            {
                if (Regex.Match(key, @"^[A-Z]*$").Success)
                {
                    key = key.Replace("J", "I");
                    string sNew = new string((key + sENG).ToCharArray().Distinct().ToArray());
                    flag = 1;
                    fillGrid(sNew, 5);
                    MessageBox.Show("Ключ установлен");
                }
                else
                    MessageBox.Show("Некорректный ввод ключа (принимаются только символы английского алфавита без пробелов и знаков препинания)" +
                        "\nили выберите другой язык", "Ошибка", MessageBoxButtons.OK);
            }
            else if (radioButtonRUS.Checked)
            {
                if (Regex.Match(key, @"^[А-ЯЁ]*$").Success)
                {
                    string sNew = new string((key + sRUS).ToCharArray().Distinct().ToArray());
                    flag = 2;
                    fillGrid(sNew, 6);
                    MessageBox.Show("Ключ установлен");
                }
                else
                    MessageBox.Show("Некорректный ввод ключа (принимаются только символы русского алфавита без пробелов и знаков препинания)" +
                        "\nили выберите другой язык", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void buttonENC_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                MessageBox.Show("Сначала установите ключ");
            }
            else
            {
                string orig_mes = textBoxOrig.Text.ToUpper();
                if (flag == 1)
                {
                    orig_mes = Regex.Replace(orig_mes, @"[^A-Z]+", String.Empty);
                    orig_mes = orig_mes.Replace("J", "I");
                }
                else if (flag == 2)
                {
                    orig_mes = Regex.Replace(orig_mes, @"[^А-ЯЁ .,]+", String.Empty);
                }
                textBoxEnc.Text = encrypt(orig_mes);
            }
        }

        private void buttonDEC_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                MessageBox.Show("Сначала установите ключ");
            }
            else
            {
                string enc_mes = textBoxEnc.Text.ToUpper();
                if (flag == 1)
                {
                    enc_mes = enc_mes.Replace("J", "I");
                    if (!Regex.Match(enc_mes, @"^[A-Z]*$").Success)
                        MessageBox.Show("Некорректный ввод зашифрованного сообщения");
                    else
                        textBoxDec.Text = decrypt(enc_mes);
                }
                else if (flag == 2)
                {
                    if (!Regex.Match(enc_mes, @"^[А-ЯЁ .,]*$").Success)
                        MessageBox.Show("Некорректный ввод зашифрованного сообщения");
                    else
                        textBoxDec.Text = decrypt(enc_mes);
                }
            }
        }
    }
}
