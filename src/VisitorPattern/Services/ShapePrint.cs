using System.Text;
using VisitorPattern.Interfaces;

namespace VisitorPattern.Services
{
    public class ShapePrint : IShapeVisitor
    {
        readonly StringBuilder sb = new();

        public void Visit(Square square)
        {
            sb.AppendLine("<cuadrado>");
            sb.Append($"<tamaño value={square.Size}/>");
            sb.AppendLine("</cuadrado>");
        }

        public void Visit(Circle circle)
        {
            sb.AppendLine("<circulo>");
            sb.Append($"<radio value={circle.Radius}/>");
            sb.AppendLine("</circulo>");
        }

        public void Visit(JoinShapes joinShapes)
        {
            sb.AppendLine("<figuras>");
            joinShapes.Left.Accept(this);
            joinShapes.Right.Accept(this);
            sb.AppendLine("</figuras>");
        }

        public override string ToString() => sb.ToString();
    }
}
