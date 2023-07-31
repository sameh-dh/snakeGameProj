using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace SnakeGameProj
{
    public static class Images
    {
        public readonly static ImageSource Empty = LoadImage("Empty");
   
    //Method LoadIMage
    private static ImageSource LoadImage(string fileName)
    {
        return new BitmapImage(new Uri($"Assets/{fileName}",UriKind.Relative));
    }

    }
}
