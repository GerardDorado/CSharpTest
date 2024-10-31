public interface IFigure
{
    int perimeter { get; set; }
    int area { get; set; }
    public List<Point> Draw();
}