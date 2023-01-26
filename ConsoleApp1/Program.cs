using Figures;

IFigure figure = new Box(5, 4);
Console.WriteLine($"Площадь квадрата: {figure.GetSquare()}");

figure = new Circle(5);
Console.WriteLine($"Площадь круга: {figure.GetSquare()}");

figure = new Triangle(3, 4, 5);
Console.WriteLine($"Площадь треугольника: {figure.GetSquare()}");
Console.WriteLine($"Треугольник прямоугольный: {(figure as Triangle).IsRight()}");

Console.ReadKey();