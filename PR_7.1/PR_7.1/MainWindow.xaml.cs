using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Threading;

namespace PR_7._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();
        List<string> texts = new List<string>()
        {
            "Шлепки никому еще не навредили",
            "Согласиться с ребенком значит показать свою слабость и проиграть",
            "После первых трех лет мозг ребенка окончательно сформирован",
            "Дети становятся гиперактивными от сахара",
            "Ребенка нужно беречь от переживания утрат"
        };

        DispatcherTimer timer; // таймер в очереди

        public MainWindow()
        {
            InitializeComponent();

            // Инициализация таймера
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2); // Интервал в 2 секунды
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) // Получение случайного текста
        {
            int randomIndex = rand.Next(texts.Count); // Генерация/переход по размеру texts (List*)
            string randomText = texts[randomIndex]; // Обновление/перевод текста в randomText

            TextBoxForMyths.Text = randomText; // Обновление текста в TextBoxForMyths
        }

        private void Feed_Click(object sender, RoutedEventArgs e)
        {
            TextBoxForButton.Text = "Дитё накормлено";
        }

        private void Wish_Click(object sender, RoutedEventArgs e)
        {
            TextBoxForButton.Text = "Дитё умыто";
        }

        private void Sleep_Click(object sender, RoutedEventArgs e)
        {
            TextBoxForButton.Text = "Дитё усыплено";
        }

        private void Education_Click(object sender, RoutedEventArgs e)
        {
            TextBoxForButton.Text = "Дитё воспитанно";
        }

        private void TextBoxForButton_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxForMyths_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
