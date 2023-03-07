public class Fraction{
    private int topNum;
    private int bottomNum;

    public Fraction(){
        topNum = 1;
        bottomNum = 1;
    }
    public Fraction(int top){
        topNum = top;
        bottomNum = 1;
    }
    public Fraction(int top, int bottom)
    {
        topNum = top;
        bottomNum = bottom;
    }


     public string GetFraction(){
        string text = $"{topNum}/{bottomNum}";
        return text;
    }

    public double GetDecimal(){
        return (double)topNum / (double)bottomNum;
    }
}