using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class ConnectFour
    {
        private Gameboard board;
        private Player[] players;
        private int currentPlayerIndex;
        private bool gameover;
        public void Start()
        {
            Console.WriteLine("Welcome to Connect Four!");
            InitializeGame();
            PlayGame();
        }
        private void InitaializeGame()
        {
        }
        private void PlayGame()
        {
        }
        private void EndGame(string message)
        {
        }
        private int GetValidInput(int min, int max)
        {
        }
        // have changed it 
    internal class Program
    {
        static char[,] board = new char[6, 7];
        // for connect four we will need 6 rows and 7 columns
        static char currentPlayer = 'X';
        // player X will start the game 
        // further should be written below or you can modify it as you wish
            static void Main(string[] args)
        {
        }
    }
}
