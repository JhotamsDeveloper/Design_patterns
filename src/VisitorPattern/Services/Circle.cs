using VisitorPattern.Abstractor;
using VisitorPattern.Interfaces;

namespace VisitorPattern.Services
{
    public class Circle : Shape
    {
        public int Radius { get; }

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public override void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
