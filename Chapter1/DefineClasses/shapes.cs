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

    public int width;
    public int height;
}