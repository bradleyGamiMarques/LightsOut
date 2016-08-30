using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightsOut
{
    public partial class MainForm : Form
    {
        private const int GridOffset = 25; // Distance from upper-left side of window
        private const int GridLength = 200; // Size in pixels of grid
        private const int NumCells = 3; // Number of cells in grid
        private const int CellLength = GridLength / NumCells;
        private bool[,] grid; // Stores on/off state of cells in grid
        private Random rand; // Used to generate random numbers
        public MainForm()
        {
            InitializeComponent();
            rand = new Random(); // Initializes random number generator
            grid = new bool[NumCells, NumCells];
            // Turn entire grid on
            for (int r = 0; r < NumCells; r++)
                for (int c = 0; c < NumCells; c++)
                    grid[r, c] = true;
        }
    }
}
