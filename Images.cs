using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace SnakeGameProj
{
    public static class Images
    {
        public readonly static ImageSource Empty = LoadImage("Empty.png");
        public readonly static ImageSource Body = LoadImage("Body.png");
        public readonly static ImageSource Head = LoadImage("Head.png");
        public readonly static ImageSource Food = LoadImage("Food.png");
        public readonly static ImageSource DeadBody = LoadImage("DeadBody");
        public readonly static ImageSource DeadHead = LoadImage("DeadHead.png");
   
    //Method LoadIMage
    private static ImageSource LoadImage(string fileName)
    {
        return new BitmapImage(new Uri($"Asset/{fileName}",UriKind.Relative));
    }

    }
}
