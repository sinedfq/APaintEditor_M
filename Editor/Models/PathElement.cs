namespace Editor.Models
{
    public class PathElement : Figures
    {
        public string Commands { get; set; }
        public string StrokeColor { get; set; }
        public double StrokeThickness { get; set; }
        public string FillColor { get; set; }
    }
}