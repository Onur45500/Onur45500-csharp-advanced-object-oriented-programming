using System.Security.Cryptography.X509Certificates;

class Rectangle
{
    public Rectangle (int w, int h)
    {
        width = w;
        height = h;
    }

    public Rectangle(int side)
    {
        width = height = side;
    }

    public int GetArea()
    {
        return width * height;
    }

    public int Width
    {
        get { return width; }
        set { width = value; }
    }

    public int Height
    {
        get { return Height; }
        set { 
            if(value < 0)
            {
                throw new ArgumentOutOfRangeException("Height", "must be >= 0");
            }

            height = value;
        }
    }

    int width;
    int height;
}