using Editor.Models;
using System.Xml.Serialization;

namespace Editor.Models
{
    public class LineElement : Figures
    {
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public string StrokeColor { get; set; }
        public double StrokeThickness { get; set; }
    }
}
