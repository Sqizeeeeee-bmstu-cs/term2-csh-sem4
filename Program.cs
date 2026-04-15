
var checkEmpty = new FigureMatrixCheckEmpty();

var matrix = new Matrix<Figure>(5, 5, checkEmpty);

matrix[0, 0] = new Circle(5);
matrix[2, 2] = new Square(10);
matrix[4, 4] = new Rectangle(2, 8);

Console.WriteLine("Текущая матрица фигур:");
Console.WriteLine(matrix.ToString());

Console.WriteLine($"Площадь фигуры в (2,2): {matrix[2, 2].Area}");

