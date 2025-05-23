Game b﻿using System;
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
          board = new GameBoard();
            gameOver = false;
            
            Console.WriteLine("Select game mode: ");
            Console.WriteLine("1. Two Players");
            Console.WriteLine("2. Player vs Computer");
            Console.Write("Enter choice (1-2): ");
            
            int choice = GetValidInput(1, 2);
            players = new Player[2];
            players[0] = new HumanPlayer('X', "Player 1");
            if (choice == 1)
            {
                players[1] = new HumanPlayer('O', "Player 2");
            }
            else
            {
                players[1] = new ComputerPlayer('O', "Computer");
            }
            currentPlayerIndex = 0;
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
