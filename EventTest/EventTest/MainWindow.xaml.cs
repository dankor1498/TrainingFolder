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

namespace EventTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hero hero;
        public MainWindow()
        {
            InitializeComponent();
            hero = new Hero(100);
            hero.HeroEvent += PrintMessage;

        }

        private void PrintMessage(object sender, string message)
        {
            Result.Text += message + " Жизнь: " + ((Hero)sender).Life + '\n';
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            hero.ChangeLife(-random.Next(10, 20));
        }
    }

    public class Hero
    {
        int life;

        public delegate void ButtonHandler(object sender, string message);
        public event ButtonHandler HeroEvent;
        public Hero(int life)
        {
            this.life = life;
        }

        public int Life { get => life; }
        
        public void ChangeLife(int life)
        {
            this.life += life;
            if (this.life < 0)
            {
                if (HeroEvent != null)
                {
                    HeroEvent(this, "Вы умерли!");
                    return;
                }
            }
            if (this.life < 20)
            {
                if(HeroEvent != null)
                {
                    HeroEvent(this, "Вы скоро умрете!");
                    return;
                }
            }
            HeroEvent(this, "Мы слабеем!");
        }
    }
}
