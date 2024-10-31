public class ExportCanvas : ICanvas
{
      IFigure[] figures { get; set; };

      public void Export(string filepath)
      {
            //Create file
            foreach (var figure in figures)
            {
                  List<Point> points = figure.Draw()
               //Write bitmap into the file using the values provided by the figure
         }

            //Save and close the file
      }
}