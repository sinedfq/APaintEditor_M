using System;

namespace Editor.Models
{
    public class PolylineElement : Figures
    {
        public string Points { get; set; }
        public string StrokeColor { get; set; }
        public double StrokeThickness { get; set; }
    }
}