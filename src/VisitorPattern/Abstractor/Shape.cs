using VisitorPattern.Interfaces;

namespace VisitorPattern.Abstractor
{
    public abstract class Shape
    {
        public abstract void Accept(IShapeVisitor visitor);
    }
}
