using MahApps.Metro;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using TERA_Glyph_Calculator.Class_Windows;

namespace TERA_Glyph_Calculator {

    public partial class MainWindow {

        public MainWindow() {

            InitializeComponent();
            loadImages();

        }

        private void loadImages() {

            #region Variables and whatnot

            var ResourceLocation = "pack://application:,,,/Resources/";

            #endregion
             
            #region Heal classses
            MysticClick.Content = new Image {
                Source = new BitmapImage(new Uri(new Uri(ResourceLocation, UriKind.Absolute), new Uri(@"/images/Class Images/mystic_class.png", UriKind.Relative)))
            };
            PriestClick.Content = new Image {
                Source = new BitmapImage(new Uri(new Uri(ResourceLocation, UriKind.Absolute), new Uri(@"/images/Class Images/priest_class.png", UriKind.Relative)))
            };
            #endregion 

            #region Melee Classes
            BerserkerClick.Content = new Image {
                Source = new BitmapImage(new Uri(new Uri(ResourceLocation, UriKind.Absolute), new Uri(@"/images/Class Images/berserker_class.png", UriKind.Relative)))
            };
            NinjaClick.Content = new Image {
                Source = new BitmapImage(new Uri(new Uri(ResourceLocation, UriKind.Absolute), new Uri(@"/images/Class Images/ninja_class.png", UriKind.Relative)))
            };
            ReaperClick.Content = new Image {
                Source = new BitmapImage(new Uri(new Uri(ResourceLocation, UriKind.Absolute), new Uri(@"/images/Class Images/reaper_class.png", UriKind.Relative)))
            };
            SlayerClick.Content = new Image {
                Source = new BitmapImage(new Uri(new Uri(ResourceLocation, UriKind.Absolute), new Uri(@"/images/Class Images/slayer_class.png", UriKind.Relative)))
            };
            ValkyrieClick.Content = new Image {
                Source = new BitmapImage(new Uri(new Uri(ResourceLocation, UriKind.Absolute), new Uri(@"/images/Class Images/valkyrie_class.png", UriKind.Relative)))
            };
            WarriorClick.Content = new Image {
                Source = new BitmapImage(new Uri(new Uri(ResourceLocation, UriKind.Absolute), new Uri(@"/images/Class Images/warrior_class.png", UriKind.Relative)))
            };
            #endregion 

            #region Ranged Classes
            ArcherClick.Content = new Image {
                Source = new BitmapImage(new Uri(new Uri(ResourceLocation, UriKind.Absolute), new Uri(@"/images/Class Images/archer_class.png", UriKind.Relative)))
            };
            GunnerClick.Content = new Image {
                Source = new BitmapImage(new Uri(new Uri(ResourceLocation, UriKind.Absolute), new Uri(@"/images/Class Images/gunner_class.png", UriKind.Relative)))
            };
            SorcererClick.Content = new Image {
                Source = new BitmapImage(new Uri(new Uri(ResourceLocation, UriKind.Absolute), new Uri(@"/images/Class Images/sorcerer_class.png", UriKind.Relative)))
            };
            #endregion  

            #region Tank Classes
            BrawlerClick.Content = new Image {
                Source = new BitmapImage(new Uri(new Uri(ResourceLocation, UriKind.Absolute), new Uri(@"/images/Class Images/brawler_class.png", UriKind.Relative)))
            };
            LancerClick.Content = new Image {
                Source = new BitmapImage(new Uri(new Uri(ResourceLocation, UriKind.Absolute), new Uri(@"/images/Class Images/lancer_class.png", UriKind.Relative)))
            };
            #endregion

        }

        #region Show Melee Windows
        private void Berserker2_Click(object sender, RoutedEventArgs e) {
            // MessageBox.Show("Berserker");
            this.Hide();
            Berserker berserker = new Berserker();
            berserker.ShowDialog();
            this.Show();
        }
        private void Ninja2_Click(object sender, RoutedEventArgs e) {
            //MessageBox.Show("Ninja");
            this.Hide();
            Ninja ninja = new Ninja();
            ninja.ShowDialog();
            this.Show();
        }
        private void Reaper2_Click(object sender, RoutedEventArgs e) {
            //MessageBox.Show("Reaper");
            this.Hide();
            Reaper reaper = new Reaper();
            reaper.ShowDialog();
            this.Show();
        }
        private void Slayer2_Click(object sender, RoutedEventArgs e) {
            // MessageBox.Show("Slayer");
            this.Hide();
            Slayer slayer = new Slayer();
            slayer.ShowDialog();
            this.Show();
        }
        private void Valkyrie2_Click(object sender, RoutedEventArgs e) {
            //MessageBox.Show("Valkyrie");
            this.Hide();
            Valkyrie valkyrie = new Valkyrie();
            valkyrie.ShowDialog();
            this.Show();
        }
        private void Warrior2_Click(object sender, RoutedEventArgs e) {
            // MessageBox.Show("Warrior");
            this.Hide();
            Warrior warrior = new Warrior();
            warrior.ShowDialog();
            this.Show();
        }
        #endregion

        #region Show Ranged Windows
        private void Archer2_Click(object sender, RoutedEventArgs e) {
            //MessageBox.Show("Archer");
            this.Hide();
            Archer archer = new Archer();
            archer.ShowDialog();
            this.Show();
        }

        private void Gunner2_Click(object sender, RoutedEventArgs e) {
            //MessageBox.Show("Gunner");
            this.Hide();
            Gunner gunner = new Gunner();
            gunner.ShowDialog();
            this.Show();

        }

        private void Sorcerer2_Click(object sender, RoutedEventArgs e) {
            //MessageBox.Show("Sorcerer");
            this.Hide();
            Sorcerer sorcerer = new Sorcerer();
            sorcerer.ShowDialog();
            this.Show();
        }
        #endregion

        #region Show Healer Windows
        private void Priest2_Click(object sender, RoutedEventArgs e) {
            // MessageBox.Show("Priest");
            this.Hide();
            Priest priest = new Priest();
            priest.ShowDialog();
            this.Show();
        }

        private void Mystic2_Click(object sender, RoutedEventArgs e) {
            // MessageBox.Show("Mystic");
            this.Hide();
            Mystic mystic = new Mystic();
            mystic.ShowDialog();
            this.Show();
        }
        #endregion

        #region Show Tank Windows
        private void Brawler2_Click(object sender, RoutedEventArgs e) {
            //MessageBox.Show("Brawler");
            this.Hide();
            Brawler brawler = new Brawler();
            brawler.ShowDialog();
            this.Show();
        }

        private void Lancer2_Click(object sender, RoutedEventArgs e) {
            //MessageBox.Show("Lancer");
            this.Hide();
            Lancer lancer = new Lancer();
            lancer.ShowDialog();
            this.Show();
        }
        #endregion

    }
}
