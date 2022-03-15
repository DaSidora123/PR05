using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR05
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int p, q, n, w, publicExp;

        float privateExp;

        private void EncryptBtnClick(object sender, EventArgs e)
        {
            encryptTextBox.Text = Encrypt(WordTextBox.Text);
        }

        public int IsSimple(int n1, int n2)
        {
            while (n2 != 0)
            {
                n2 = n1 % (n1 = n2);
            }
            return n1;
            //if (n1 == n2)
            //{
            //    return n1;
            //}
            //else
            //{
            //    if (n1 > n2)
            //    {
            //        return IsSimple(n1 - n2, n2);
            //    }
            //    else
            //    {
            //        return IsSimple(n2 - n1, n1);
            //    }
            //}
        }

        private string Encrypt(string str)
        {
            var arr = str.ToCharArray();
            List<char> encArr = new List<char>();

            foreach (var symbol in arr)
            {
                int c = 1;
                int nn = 0;
                //encArr.Add(Convert.ToChar((int)Math.Pow((int)symbol, publicExp) % n));
                do
                {
                    nn++;
                    c = ((int)symbol * c) % n;

                } while (nn < publicExp);
                encArr.Add(Convert.ToChar(c));
            }

            string str1 = null;
            foreach (var item in encArr)
            {
                str1 += item.ToString();
            }
            return str1;
        }

        private string Decript(string str)
        {
            var arr = str.ToCharArray();
            List<char> encArr = new List<char>();

            foreach (var symbol in arr)
            {
                int c = 1;
                int nn = 0;
                do
                {
                    nn++;
                    c = ((int)symbol * c) % n;

                } while (nn < privateExp);
                encArr.Add(Convert.ToChar(c));
            }

            string str1 = null;
            foreach (var item in encArr)
            {
                str1 += item.ToString();
            }
            return str1;
        }

        private void DecryptTbnClick(object sender, EventArgs e)
        {
            long n = Convert.ToInt32(KeyTextBox1.Text);
            long m = Convert.ToInt32(KeyTextBox2.Text);
            List<char> str = encryptTextBox.Text.ToList<char>();
            decryptTextBox.Text = Decript(encryptTextBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bool simple = false;

            while (!simple)
            {
                p = rnd.Next(3, 256);
                for (int i = 2; i < p; i++)
                {
                    if (p % i == 0)
                    {
                        simple = false;
                        break;
                    }
                    else
                    {
                        simple = true;
                    }
                }
            }
            while (!Simple(publicExp))
            {
                simple = false;
                while (!simple)
                {
                    q = rnd.Next(3, 256);
                    for (int i = 2; i < q; i++)
                    {
                        if (q % i == 0)
                        {
                            simple = false;
                            break;
                        }
                        else
                        {
                            simple = true;
                        }
                    }
                }

                n = p * q;

                w = (p - 1) * (q - 1);


                publicExp = rnd.Next(1, w);
                while (publicExp < w / 2)
                {
                    publicExp = rnd.Next(1, w);
                    if (IsSimple(publicExp, w) == 1)
                    {
                        break;
                    }
                }
            }
            long c = 10;

            while (true)
            {
                if ((c * publicExp) % w == 1)
                    break;
                else
                    c++;
            }

            privateExp = c;

            KeyTextBox1.Text = p.ToString();
            KeyTextBox2.Text = q.ToString();
        }

        private bool Simple(int x)
        {
            bool simple = false;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    simple = false;
                    break;
                }
                else
                {
                    simple = true;

                }
            }
            return simple;
        }

        private void ResetBtnClick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bool simple = false;

            while (!simple)
            {
                p = rnd.Next(3, 256);
                for (int i = 2; i < p; i++)
                {
                    if (p % i == 0)
                    {
                        simple = false;
                        break;
                    }
                    else
                    {
                        simple = true;
                    }
                }
            }
            while (!Simple(publicExp))
            {
                simple = false;
                while (!simple)
                {
                    q = rnd.Next(3, 256);
                    for (int i = 2; i < q; i++)
                    {
                        if (q % i == 0)
                        {
                            simple = false;
                            break;
                        }
                        else
                        {
                            simple = true;
                        }
                    }
                }

                n = p * q;

                w = (p - 1) * (q - 1);


                publicExp = rnd.Next(1, w);
                while (publicExp < w / 2)
                {
                    publicExp = rnd.Next(1, w);
                    if (IsSimple(publicExp, w) == 1)
                    {
                        break;
                    }
                }
            }
            long c = 10;

            while (true)
            {
                if ((c * publicExp) % w == 1)
                    break;
                else
                    c++;
            }

            privateExp = c;

            encryptTextBox.Text = null;
            KeyTextBox1.Text = p.ToString();
            KeyTextBox2.Text = q.ToString();
        }

    }
}
