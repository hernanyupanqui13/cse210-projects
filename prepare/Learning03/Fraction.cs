using System;

class Fraction {
    private int _top;
    private int _bottom;


    public Fraction() {
       this._bottom = 1;
       this._top = 1;
    }

    public Fraction (int wholeNumber) {
        this._top = wholeNumber;
        this._bottom = 1;
    }

    public Fraction(int top, int bottom) {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop() {
        return this._top; 
    }

    public void SetTop(int top) {
        this._top = top;
    }

    public int GetBottom() {
        return _bottom;
    }

    public void SetBottom(int bottom) {
        this._bottom = bottom;
    }

    public string GetFractionString() {
        return $"{this._top}/{this._bottom}";
    }

    public double GetDecimalValue() {
        return (double) this._top / (double) this._bottom;
    }
    
}