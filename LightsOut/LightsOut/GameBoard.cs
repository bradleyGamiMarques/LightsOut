using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightsOut
{
    class GameBoard
    {
        private bool[,] grid;                   // Stores on/off state of cells in grid
        private Random rand;		            // Used to generate random numbers
        private int numCells = 3;               // Number of cells in grid

        public int NumCells
        {
            get
            {
                return numCells;
            }
            set
            {
                if (value < 3 || value > 5)
                {
                    throw new Exception("NumCells can only be 3, 4, or 5");
                }
                else
                {
                    numCells = value;
                }
            }
        }
        public GameBoard()
        {
            rand = new Random();    // Initializes random number generator

            grid = new bool[numCells, numCells];

            // Turn entire grid on
            for (int r = 0; r < numCells; r++)
                for (int c = 0; c < numCells; c++)
                    grid[r, c] = true;
        }

        public void StartNewGame()
        {
            grid = new bool[numCells, numCells];

            // Fill grid with either white or black
            for (int r = 0; r < numCells; r++)
                for (int c = 0; c < numCells; c++)
                    grid[r, c] = rand.Next(2) == 1;
        }

        public bool IsGridOn(int row, int col)
        {
            return grid[row, col];
        }

        public void MakeMove(int row, int col)
        {
            for (int i = row - 1; i <= row + 1; i++)
                for (int j = col - 1; j <= col + 1; j++)
                    if (i >= 0 && i < numCells && j >= 0 && j < numCells)
                        grid[i, j] = !grid[i, j];
        }

        public bool PlayerWon()
        {
            for (int r = 0; r < numCells; r++)
                for (int c = 0; c < numCells; c++)
                    if (grid[r, c])
                        return false;

            return true;
        }
    }
}
