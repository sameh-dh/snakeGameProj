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

namespace SnakeGameProj
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly int rows = 15, cols = 15;
        private readonly Image[,] gridImages;
     
        public MainWindow()
        {
            InitializeComponent();
            gridImages= SetupGrid();
            Console.WriteLine("Hollllllaaaa");
           
        }

        //Event 
        private  void Window_Loaded(object sender , RoutedEventArgs e)
        {
            Draw();

        }

        //Draw mthod
        private void Draw()
        {
            DrawGrid();
        }
        //DrawGrid Method
        private void DrawGrid()
        {
            
        }
        private Image[,] SetupGrid()
        {
            Image[,] images = new Image[rows, cols];
            GameGrid.Rows = rows;
            GameGrid.Columns = cols;
            for (int r=0; r<rows; r++)
            {
                for (int c=0; c<cols; c++)
                {
                    Image image = new Image
                    {
                        Source = Images.Empty
                    };
                    images[r, c] = image;
                GameGrid.Children.Add(image);

                }
            }
            Console.WriteLine(images[0, 1]) ;
            return images;
        }

      
    }
 
}
