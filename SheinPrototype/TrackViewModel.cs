namespace SheinPrototype;

public class TrackViewModel
{
    public class StatusViewModel
    {
        public string Day { get; set; }
        public string WeekDay { get; set; }
        public string Message { get; set; }
    }
    public string Token { get; set; }
    public IEnumerable<StatusViewModel> Status { get; set; }
    public bool IsFirstTime { get; set; } = false;
}