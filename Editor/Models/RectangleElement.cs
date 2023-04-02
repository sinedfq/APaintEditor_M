using System;

namespace Editor.Models
{
    public class RectangleElement : Figures
    {
        public string StartPoint { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public string StrokeColor { get; set; }
        public double StrokeThickness { get; set; }
        public string FillColor { get; set; }
    }
}
