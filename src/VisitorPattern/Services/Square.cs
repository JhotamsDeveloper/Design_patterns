using VisitorPattern.Abstractor;
using VisitorPattern.Interfaces;

namespace VisitorPattern.Services
{
    public class Square : Shape
    {
        public int Size { get; }

        public Square(int size)
        {
            this.Size = size;
        }

        public override void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
