using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathStatistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик на събитието за бутон "Средно аритметично"
        private void buttonAverage_Click_1(object sender, EventArgs e)
        {
            // Взема въведените числа от текстовото поле, разделени с интервали, и ги превръща в списък от реални числа
            List<double> list = textBoxNumber1.Text.Split(' ').Select(l => double.Parse(l)).ToList();

            // Изчислява средното аритметично от числата в списъка
            var averageNum = list.Average();

            // Показва средното аритметично в етикета
            labelAverage.Text = ("Average: " + averageNum);
        }

        // Обработчик на събитието за бутон "Медиана"
        private void buttonMedian_Click_1(object sender, EventArgs e)
        {
            // Взема въведените числа от текстовото поле, разделени с интервали
            string[] numbersStr = textBoxNumber2.Text.Split(' ');

            // Преобразува символите в реални числа
            double[] numbers = Array.ConvertAll(numbersStr, Double.Parse);

            // Сортира масива с числа
            Array.Sort(numbers);

            // Изчислява медианата
            double median;
            if (numbers.Length % 2 == 0)
            {
                // Ако броят на елементите е четен
                int middle1 = numbers.Length / 2 - 1;
                int middle2 = numbers.Length / 2;
                median = (numbers[middle1] + numbers[middle2]) / 2;
            }
            else
            {
                // Ако броят на елементите е нечетен
                int middle = numbers.Length / 2;
                median = numbers[middle];
            }

            // Показва медианата в текстовото поле за резултат
            labelMedian.Text = "Median: " + median.ToString();
        }

        // Обработчик на събитието за бутон "Мода"
        private void buttonMode_Click_1(object sender, EventArgs e)
        {
            // Взема въведените числа от текстовото поле, разделени с интервали
            string[] numbersString = textBoxNumber3.Text.Split(' ');

            // Преобразува числата от текст в масив от цели числа
            int[] numbers = numbersString.Select(int.Parse).ToArray();

            // Намира модата
            int mode = FindMode(numbers);

            // Показва резултата
            labelMode.Text = "Mode: " + mode;
        }

        // Метод за намиране на модата
        private int FindMode(int[] numbers)
        {
            var groups = numbers.GroupBy(x => x);
            var sortedGroups = groups.OrderByDescending(g => g.Count());
            var modeGroup = sortedGroups.First();
            int mode = modeGroup.Key;

            return mode;
        }

        private void buttonChart_Click_1(object sender, EventArgs e)
        {
            // Взема въведените от потребителя данни от текстовото поле
            string userInput = textBoxNumber4.Text;

            // Разделя въведените данни на отделни числа
            string[] numbersArray = userInput.Split(' ');

            // Обработва всяко число и го добавя към графиката
            foreach (string numberStr in numbersArray)
            {
                if (double.TryParse(numberStr, out double number))
                {
                    // Добавя новата точка с данни към графиката
                    chart1.Series[0].Points.AddY(number);
                }
                else
                {
                    MessageBox.Show($"Invalid input: {numberStr}.");
                    // Изчиства графиката при невалиден вход (по избор)
                    chart1.Series[0].Points.Clear();
                    break; // Излиза от цикъла при срещане на невалиден вход
                }
            }
        }
    }
}
