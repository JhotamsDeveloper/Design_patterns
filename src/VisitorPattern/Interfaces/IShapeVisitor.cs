using VisitorPattern.Services;

namespace VisitorPattern.Interfaces
{
    public interface IShapeVisitor
    {
        void Visit(Square square);
        void Visit(Circle circle);
        void Visit(JoinShapes joinShapes);

    }
}
