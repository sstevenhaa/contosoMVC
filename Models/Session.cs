namespace ContosoConfApp.Models
{
    public class Session
    {

        
        public string subject { get; set; }
        
        public string date { get; set; }

        public string details { get; set; }

        public int seats {get; set;}
        public string speaker { get; set; }



    }

    public class Sessions
    {
        public IList<Session> sessions { get; set; }
    }

}
