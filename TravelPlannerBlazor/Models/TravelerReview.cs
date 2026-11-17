namespace TravelPlannerBlazor.Models;

public class TravelerReview
{
    public string TravelerName { get; set; } = string.Empty;
    public string DestinationName { get; set; } = string.Empty;
    public int Rating { get; set; } = 5;
    public string Comment { get; set; } = string.Empty;
    public DateTime DatePosted { get; set; } = DateTime.Now;
}