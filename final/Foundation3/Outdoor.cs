class Outdoor:Event{
    //weather
    public Outdoor(){}

    string _weather;
    public void SetWeather(string weather){
        _weather = weather;
    }
    public string GetWeather(){
        string weather = $"Weather Report: {_weather}";
        return weather;
    }
}