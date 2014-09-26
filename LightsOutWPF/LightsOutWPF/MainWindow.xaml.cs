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

namespace LightsOutWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int GRID_OFFSET = 10;
        private static int NUM_CELLS = 3;
        //private static int CELL_LENGTH = GRID_LENGTH / NUM_CELLS;

        private bool[,] grid;
        private Random rand;

        private Rectangle rect = new Rectangle();

        public MainWindow()
        {
            InitializeComponent();

            rand = new Random();

            grid = new bool[NUM_CELLS, NUM_CELLS];

            paintCanvas.Width = 300;
            paintCanvas.Height = paintCanvas.Width;

            // turn entire grid on
            for (int r = 0; r < NUM_CELLS; r++)
            {
                for (int c = 0; c < NUM_CELLS; c++)
                {
                    grid[r, c] = true;
                    
                    rect.Width = paintCanvas.Width * 33.33 / 100;
                    rect.Height = rect.Width;

                    Canvas.SetTop(rect, rect.Width * r);
                    Canvas.SetLeft(rect, rect.Height * c);
                    paintCanvas.Children.Add(rect);

                    rect = new Rectangle();
                }
            }

            this.DrawGrid();
        }

        private void DrawGrid()
        {
            int index = 0;

            // Set each rectangle's color
            for(int r = 0; r < NUM_CELLS; r++)
            {
                for(int c = 0; c < NUM_CELLS; c++)
                {
                    Rectangle rect = paintCanvas.Children[index] as Rectangle;
                    index++;

                    if(grid [r, c])
                    {
                        // On
                        rect.Fill = Brushes.White;
                        rect.Stroke = Brushes.Black;
                    }
                    else
                    {
                        // Off
                        rect.Fill = Brushes.Black;
                        rect.Stroke = Brushes.White;
                    }
                }
            }
        }

        private void paintCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Find row, col of mouse press
            int r = ((int)e.GetPosition(paintCanvas).Y) / (int)(paintCanvas.Width / NUM_CELLS);
            int c = ((int)e.GetPosition(paintCanvas).X) / (int)(paintCanvas.Width / NUM_CELLS);

            // Invert selected box and all surrounding boxes
            for (int i = r - 1; i <= r + 1; i++)
                for (int j = c - 1; j <= c + 1; j++)
                    if (i >= 0 && i < NUM_CELLS && j >= 0 && j < NUM_CELLS)
                        grid[i, j] = !grid[i, j]; 

            this.DrawGrid();
        }
    }
}
