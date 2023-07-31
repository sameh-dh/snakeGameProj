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
       
     
        public MainWindow()
        {
            InitializeComponent();
            SetupGrid();
        }

        //Event 
        private  void Window_Loaded(object sender , RoutedEventArgs e)
        {
          
         
        }

        //Draw mthod
        private void Draw()
        {
           
        }
        //DrawGrid Method
        private void SetupGrid()
        {
            GameGrid.Rows = rows;
            GameGrid.Columns = cols;
            for (int r=0; r<rows; r++)
            {
                for (int c=0; c<cols; c++)
                {

               
                Border GridContent = new Border();
                GridContent.Background = Brushes.White;
                GameGrid.Children.Add(GridContent);

                }
            }
        }
    }
}
