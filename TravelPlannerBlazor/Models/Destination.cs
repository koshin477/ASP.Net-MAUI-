namespace TravelPlannerBlazor.Models;

public class Destination
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Division { get; set; } = string.Empty;
    public string District { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty; 
    public string ImageUrl { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string IdealDuration { get; set; } = string.Empty; 
    public decimal EstimatedCostPerPerson { get; set; }
    public List<string> Activities { get; set; } = new();
    public string HowToGo { get; set; } = string.Empty;
    public string BestTimeToVisit { get; set; } = string.Empty;
    public string FamousFood { get; set; } = string.Empty;
}