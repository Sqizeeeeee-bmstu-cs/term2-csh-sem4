


public class FigureMatrixCheckEmpty : IMatrixCheckEmpty<Figure>
{
    

    public Figure GetEmptyElement() => null!;

    public bool CheckEmptyElement(Figure element) => element is null;

}
