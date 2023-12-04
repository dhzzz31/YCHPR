using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pr_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Обработчик событий для кнопки "Выход"
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Закрываем форму
            this.Close();
        }

        // Обработчик событий для кнопки "Очистить"
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Очищаем текст
            txtm.Clear();
            txtn.Clear();
        }

        // Обработчик событий для кнопки "Перестановка"
        private void BtnPermutation_Click(object sender, EventArgs e)
        {
            // Получаем значение из текстового поля
            int n = int.Parse(txtn.Text);
            // Вычисляем факториал числа n
            int result = Factorial(n);
            // Отображение результата в метке
            label3.Text = result.ToString();
        }
        // метод вычисления факториала числа
        private int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        private void btnCombination_Click(object sender, EventArgs e)
        {
            // Получаем значения n и m из текстовых полей
            int n = int.Parse(txtn.Text);
            int m = int.Parse(txtm.Text);
            // Вычисляем значение C(m,n)
            double result = CalculateCombination(m, n);
            if (n<m)
            {
                // Проверяем, меньше ли n, чем m, выводим сообщение об ошибке
                MessageBox.Show("Ошибка: n < m");
            } 

            else
            {
                label3.Text = result.ToString();
            }

        }
        // Вычисляем комбинацию C(m, n) и отображаем результат
        private double CalculateCombination(int m, int n)
        {
            // Вычисляем факториалы чисел m и n
            double factorialM = Factorial1(m);
            double factorialN = Factorial1(n);
            // Вычисляем факториал числа (n-m)
            double factorialNM = Factorial1(n - m);
            // Вычисляем C(m,n)
            double combination = factorialN / (factorialM * factorialNM);
            return combination;
        }
        // Метод вычисления факториала с использованием итерации
        private double Factorial1(int number)
        {
           if (number == 0 || number == 1)
               return 1;

           long result = 1;

            // Вычисляем факториал с помощью цикла
            for (int i = 2; i <= number; i++)
           {
             result *= i;
           }

           return result;
        }

        // Обработчик событий для кнопки "Размещение"
        private void btnPlacement_Click(object sender, EventArgs e)
        {
            // Получаем значения n и m из текстовых полей
            int n = int.Parse(txtn.Text);
            int m = int.Parse(txtm.Text);
            int result = Permutation(m, n);
            // Проверяем, меньше ли n, чем m, выводим сообщение об ошибке
            if (n < m)
            {
                MessageBox.Show("Ошибка: n < m");
            }
            else
            {
                // Вычисляем перестановку P(m, n) и отображаем результат
                label3.Text = result.ToString();
            }
        }
        // Метод вычисления перестановки P(m, n)
        public static int Permutation(int m, int n)
        {
            // Вычисляем перестановку, используя предоставленный метод Factorial2
            return Factorial2(n) / Factorial2(n - m);
        }

        // Метод вычисления факториала с использованием рекурсии
        public static int Factorial2(int number)
        {
            if (number <= 1)
                return 1;
            else
                return number * Factorial2(number - 1);
        }
    }
}
