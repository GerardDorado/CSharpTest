public class BitmapCanvas : ICanvas
{
    IFigure[] figures { get; set; };

    public void DrawBitmap()
    {
        //Implementation
        foreach (var figure in figures)
        {
            List<Point> points = figure.Draw()


         }
    }

    private void DrawInScreen(List<Point> points)
    {
        foreach (var point in points)
        {
            //Draw the point
        }
    }
}