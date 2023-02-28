public class Job{

    public string _jobTitle = "";
    public string _companyName = "";
    public string _startDate = "";
    public string _endDate = "";
    public Job(){}
    public void DisplayJobs(){
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startDate}-{_endDate}");
    }

}