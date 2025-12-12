using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.Q12._2_Lab02_24520602
{
    public partial class Lab02_Bai3 : Form
    {
        public Lab02_Bai3()
        {
            InitializeComponent();
        }

        private void btn_docfile_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("input3.txt"))
                {
                    rtb_noidung.Text = sr.ReadToEnd();
                }
                MessageBox.Show("Đọc file thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        static double UseOperator(double num1, double num2, char op)
        {
            switch (op)
            {
                case '+': return num1 + num2;
                case '-': return num1 - num2;
                case '*': return num1 * num2;
                case '/': return num1 / num2;
                default: return 0;
            }
        }

        static int DoUuTien(char op)
        {
            if (op == '+' || op == '-') return 1;
            if (op == '*' || op == '/') return 2;
            return 0;
        }

        static double TinhToan(string pheptinh)
        {
            Stack<char> toantu = new Stack<char>();
            Stack<double> so = new Stack<double>();
            for (int i = 0; i < pheptinh.Length; i++)
            {
                char ch = pheptinh[i];
                // Nếu là khoảng trắng thì lặp tiếp
                if (ch == ' ') continue;
                // Nếu là số
                if (ch == '-' && (i == 0 || pheptinh[i - 1] == '(' || IsOperator(pheptinh[i - 1])))
                {
                    string number = "-";
                    i++;
                    while (i < pheptinh.Length && (char.IsDigit(pheptinh[i]) || pheptinh[i] == '.'))
                    {
                        number += pheptinh[i];
                        i++;
                    }
                    i--;
                    so.Push(double.Parse(number));
                }
                else if (char.IsDigit(ch) || ch == '.')
                {
                    string number = "";
                    while (i < pheptinh.Length && (char.IsDigit(pheptinh[i]) || pheptinh[i] == '.'))
                    {
                        number += pheptinh[i];
                        i++;
                    }
                    i--;
                    so.Push(double.Parse(number));
                }
                // Nếu là dấu ngoặc mở
                else if (ch == '(')
                {
                    toantu.Push(ch);
                }
                // Nếu là dấu ngoặc đóng
                else if (ch == ')')
                {
                    while (toantu.Count > 0 && toantu.Peek() != '(')
                    {
                        double num2 = so.Pop();
                        double num1 = so.Pop();
                        char op = toantu.Pop();
                        so.Push(UseOperator(num1, num2, op));
                    }
                    toantu.Pop();
                }
                // Nếu là toán tử
                else if (IsOperator(ch))
                {
                    while (toantu.Count > 0 && DoUuTien(toantu.Peek()) >= DoUuTien(ch))
                    {
                        double num2 = so.Pop();
                        double num1 = so.Pop();
                        char op = toantu.Pop();
                        so.Push(UseOperator(num1, num2, op));   
                    }
                    toantu.Push(ch);
                }
            }
            while (toantu.Count > 0)
            {
                double num2 = so.Pop();
                double num1 = so.Pop();
                char op = toantu.Pop();
                so.Push(UseOperator(num1, num2, op));
            }
            return so.Pop();
        }

        private void btn_tinhtoan_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("input3.txt");
            rtb_noidung.Clear();
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                if (line.Any(char.IsLetter)) continue;
                double result = TinhToan(line);
                string output = $"{line} = {result}";
                rtb_noidung.AppendText(output + Environment.NewLine);
            }
            MessageBox.Show("Tính toán thành công!");
        }

        private void btn_luufile_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("output3.txt"))
                {
                    sw.Write(rtb_noidung.Text);
                }
                MessageBox.Show("Lưu file thành công!");
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rtb_noidung_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
