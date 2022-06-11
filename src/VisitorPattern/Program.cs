using VisitorPattern.Services;

var shapes = new JoinShapes(
                left: new Circle(3),
                right: new Square(10));

var print = new ShapePrint();
print.Visit(shapes);
Console.WriteLine(print.ToString());
Console.ReadLine();
