/*
 * 8.   Skriv ett uttryck som kontrollerar om en given punkt (x, y) ligger 
 *      innanför cirkeln K((1, 1), 3) och 
 *      utanför rektangeln R(top=1, left=-1, width=6, height=2)
*/

using System.Drawing;

Point point = new Point();

Console.WriteLine("Punktens x- och y-koordinater:");
Console.Write("     x= ");
point.x = double.Parse(Console.ReadLine());

Console.Write("     y= ");
point.y = double.Parse(Console.ReadLine());

bool isInsideCircle;
bool isInsideRectangle;

isInsideCircle = InsideCircle(point);
isInsideRectangle = InsideRectangle(point);

if (isInsideCircle && isInsideRectangle)
{
    Console.WriteLine("Punkten ({0}, {1}) är innanför cirkeln och innanför rektangeln", point.x, point.y);
}
else if (!isInsideCircle && !isInsideRectangle)
{
    Console.WriteLine("Punkten ({0}, {1}) är utanför cirkeln och utanför rektangeln", point.x, point.y);
}
else if (isInsideCircle && !isInsideRectangle)
{
    Console.WriteLine("Punkten ({0}, {1}) är innanför cirkeln och utanför rektangeln", point.x, point.y);
}
else if (!isInsideCircle && isInsideRectangle)
{
    Console.WriteLine("Punkten ({0}, {1}) är utanför cirkeln och innanför rektangeln", point.x, point.y);
}


static bool InsideCircle(Point point)
{
    sbyte circleX = 1, circleY = 1, circleRadius = 3;

    point.x = point.x - circleX;
    point.y = point.y - circleY;

    if (point.x * point.x + point.y * point.y <= circleRadius * circleRadius)
    {
        return true;
    }
    else
    {
        return false;
    }
}

static bool InsideRectangle(Point point)
{
    sbyte rxLeft = -1, ryTop = 1, rxRight = 5, ryBottom = -1;

    if ((point.x >= rxLeft && point.x <= rxRight) && (point.y >= ryBottom && point.y <= ryTop))
    {
        return true;
    }
    else
    {
        return false;
    }
}
public struct Point
{
    public double x;
    public double y;

}