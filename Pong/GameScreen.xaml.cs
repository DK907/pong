using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// Die Elementvorlage "Leere Seite" ist unter http://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace Pong
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet werden kann oder auf die innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class GameScreen : Page
    {
        Rectangle player = new Rectangle();

        public GameScreen()
        {
            this.InitializeComponent();


            //Funktion?

            //createPlayground(gameField);
        }

        private void createPlayground(Canvas c)
        {
            
            player.Fill = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 0, 0));
            player.Width = 20;
            player.Height = 80;
            player.Margin = new Thickness(20);

            this.gameField.Children.Add(player);

            
        }


        private void page_keyDown(object sender, KeyRoutedEventArgs e)
        {
            switch (e.Key)
            {
                case Windows.System.VirtualKey.A:
                    Canvas.SetTop(player, Canvas.GetTop(player) - 5);
                    break;
            }
            
        }

}
    

}
