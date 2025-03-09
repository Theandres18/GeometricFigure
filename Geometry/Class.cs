using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry;
abstract class GeometricFigure
{
    public string Name { get; set; }

    public GeometricFigure(string name)
    {
        Name = name;
    }

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name}: Area = {GetArea():F2}, Perimeter = {GetPerimeter():F2}";
    }
}

class Square : GeometricFigure
{
    public double A { get; set; }

    public Square(string name, double a) : base(name)
    {
        A = a;
    }

    public override double GetArea() => A * A;
    public override double GetPerimeter() => 4 * A;
}


class Rectangle : Square
{
    public double B { get; set; }

    public Rectangle(string name, double a, double b) : base(name, a)
    {
        B = b;
    }

    public override double GetArea() => A * B;
    public override double GetPerimeter() => 2 * (A + B);
}


class Parallelogram : Rectangle
{
    public double H { get; set; }

    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
    }

    public override double GetArea() => B * H;
}


class Triangle : Rectangle
{
    public double C { get; set; }
    public double H { get; set; }

    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        C = c;
        H = h;
    }

    public override double GetArea() => (B * H) / 2;
    public override double GetPerimeter() => A + B + C;
}

class Trapeze : Triangle
{
    public double D { get; set; }

    public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
    {
        D = d;
    }

    public override double GetArea() => (B + D) * H / 2;
    public override double GetPerimeter() => A + B + C + D;
}
class Circle : GeometricFigure
{
    public double R { get; set; }

    public Circle(string name, double r) : base(name)
    {
        R = r;
    }

    public override double GetArea() => Math.PI * R * R;
    public override double GetPerimeter() => 2 * Math.PI * R;
}

class Rhombus : Square
{
    public double D1 { get; set; }
    public double D2 { get; set; }

    public Rhombus(string name, double a, double d1, double d2) : base(name, a)
    {
        D1 = d1;
        D2 = d2;
    }

    public override double GetArea() => (D1 * D2) / 2;
}

class Kite : Rhombus
{
    public double B { get; set; }

    public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
    {
        B = b;
    }

    public override double GetPerimeter() => 2 * (A + B);
}