public class Resume{

    public string _member = "";
    public List<Job>_jobs = new List<Job>();
    public Resume(){}
    public void DisplayResume(){
        Console.WriteLine($"Name: {_member} Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobs();
        }
    }

}