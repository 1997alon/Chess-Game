using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using ChessLogic;

namespace ChessUI
{
    /// <summary>
    /// Interaction logic for GameOverMenu.xaml
    /// </summary>
    public partial class GameOverMenu : UserControl
    {
        public event Action<Option> OptionSelected;

        public GameOverMenu(GameState gameState)
        {
            InitializeComponent();
            Result result = gameState.Result;
            WinnerText.Text = GetWinnerText(result.Winner);
            ReasonText.Text = GetReasonText(result.Reason, gameState.CurrentPlayer);
        }

        private static string GetWinnerText(Player winner)
        {
            if (Player.White == winner)
            {
                return "WHITE WINS";
            }
            else if (Player.Black == winner)
            {
                return "BLACK WINS";
            }
            else
            {
                return "ITS A DRAW";
            }
        }

        private static string PlayerString(Player player)
        {
            if (Player.White == player)
            {
                return "WHITE";
            }
            else if (Player.Black == player)
            {
                return "BLACK";
            }
            else
            {
                return "";
            }
        }

        private static string GetReasonText(EndReason reason, Player player)
        {
            if (EndReason.CheckMate == reason)
            {
                return $"CHECKMATE - {PlayerString(player)}";
            }
            else if (EndReason.StaleMate == reason)
            {
                return $"STALEMATE - {PlayerString(player)} CAN NOT MOVE";
            }
            else
            {
                return "";
            }
        }


        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            OptionSelected?.Invoke(Option.Restart);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            OptionSelected?.Invoke(Option.Exit);
        }
    }
}
