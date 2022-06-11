using VisitorPattern.Abstractor;
using VisitorPattern.Interfaces;

namespace VisitorPattern.Services
{
    public class JoinShapes : Shape
    {
        public Shape Left { get; }
        public Shape Right { get; }

        public JoinShapes(Shape left, Shape right)
        {
            this.Left = left;
            this.Right = right;
        }
        public override void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }

    }
}
