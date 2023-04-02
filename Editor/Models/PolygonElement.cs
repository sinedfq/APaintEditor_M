using System.Xml.Serialization;

namespace Editor.Models
{
    public class PolygonElement : Figures
    {
        public string Points { get; set; }
        public string StrokeColor { get; set; }
        public double StrokeThickness { get; set; }
        public string FillColor { get; set; }
    }
}
