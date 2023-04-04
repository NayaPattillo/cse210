class Activity{

    public virtual string GetSummary(int _miles, int _minutes){
        int speed = (_miles/_minutes)*60;
        int pace = _minutes/_miles;

        string summary = $"Distance {_minutes}min: {_miles}miles, Speed: {speed}mph, Pace: {pace}min per mile";
        return summary;
    }

}