

using System.Runtime.ExceptionServices;
using System.Text;

public class Matrix<T>(int maxX, int maxY, IMatrixCheckEmpty<T> checkEmpty)
{

    private readonly Dictionary<(int x, int y), T> _matrix = [];


    public void CheckBound(int x, int y)
    {
        if ((x < 0)|| (x >= maxX)){
            throw new ArgumentOutOfRangeException("invalid x");
        }

        if ((y < 0) || (y >= maxY))
        {
            throw new ArgumentOutOfRangeException("invalid y");
        }

    }

    public T this[int x, int y]
    {
        set 
        {
            CheckBound(x, y);
            _matrix[(x, y)] = value;


        }
        get 
        {
            CheckBound(x, y);
            if (_matrix.TryGetValue((x, y), out T value))
            {
                return value;
            }
            else
            {
                return checkEmpty.GetEmptyElement(); 
            }

        }
    }

    public override string ToString()
    {
        var b = new StringBuilder();

        for (int j = 0; j < maxY; j++)
        {
            for (int i = 0; i < maxX; i++)
            {
                T value = this[i, j];
                string s = checkEmpty.CheckEmptyElement(value) ? "-" : value.ToString();
                
                b.Append(s.PadRight(10)); 
            }
            b.AppendLine();
        }

        return b.ToString();
    }


}