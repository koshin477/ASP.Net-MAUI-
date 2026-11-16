namespace TravelPlannerBlazor.Models;

public class TourPackage
{
    public int Id { get; set; }
    public string PackageName { get; set; } = string.Empty;
    public string Division { get; set; } = string.Empty;
    public string Duration { get; set; } = string.Empty;
    public decimal PricePerPerson { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public List<string> IncludedFeatures { get; set; } = new(); // Hotel, Food, Transport
}