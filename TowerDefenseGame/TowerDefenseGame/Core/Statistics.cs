﻿
namespace TowerDefenseGame.Core
{
    using System;
    using System.Windows.Controls;
    using TowerDefenseGame.Controllers;
    using System.Windows.Media;
    using System.Security.Cryptography.X509Certificates;

    class Statistics
    {
        public static TextBlock Money { get; set; }

        public static TextBlock PlayerLife { get; set; }
        static Statistics()
        {
            Money = new TextBlock();
            PlayerLife = new TextBlock();
        }
        public static void Render()
        {
            AnimationController.Renderer.DrawText(Money, 915, 7);
            AnimationController.Renderer.DrawText(PlayerLife, 1055, 7);
        }

        public static void SetMoney(string text, Brush color)
        {
            Money.Foreground = color;
            Money.Text = text;
        }

        public static void SetLife(string text, Brush color)
        {
            PlayerLife.Foreground = color;
            PlayerLife.Text = text;
        }

        public static void Update()
        {
           SetMoney(PlayerInterfaceController.Money.ToString(), Brushes.Goldenrod);
           SetLife(PlayerInterfaceController.PlayerLife.ToString(),Brushes.Green);
        }
    }
}
