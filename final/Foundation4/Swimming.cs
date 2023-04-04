class Swimming : Activity{

    public override string GetSummary(int _laps, int _minutes){
        float distance = (float)((_laps * 50) / (1000 * 0.62));
        float speed = (distance/_minutes)*60;
        float pace = _minutes/distance;

        string summary = $"Swimming {_minutes}min: Distance- {distance}miles, Speed- {speed}mph, Pace- {pace}min per mile";
        return summary;
    }

}