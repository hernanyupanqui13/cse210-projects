public class Rectangle : Shape {
    private double _width;
    private double _lenght;

    public Rectangle(string color, double width, double lenght) {
        base.SetColor(color);
        this._width = width;
        this._lenght = lenght;
    }

    public override double GetArea() {
        return this._width * this._lenght;
    }
}