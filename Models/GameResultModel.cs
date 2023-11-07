namespace TakeAMinuteBusiness.Models
{
    public class GameResultModel
    {
        public int surveyId { get; set; }
        public string? palyerMail { get; set; }
        public List<ReAction>? result { get; set; }
    }
    public class ReAction 
    {
        public string? question { get; set; }
        public int gameInput {  get; set; }
    }
}
