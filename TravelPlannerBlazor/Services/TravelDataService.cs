using TravelPlannerBlazor.Models;

namespace TravelPlannerBlazor.Services;

public class TravelDataService
{
    public List<string> GetDivisions() => new()
    {
        "All", "Dhaka", "Chattogram", "Sylhet", "Rajshahi", "Khulna", "Barishal", "Rangpur", "Mymensingh"
    };

    public List<Destination> GetDestinations() => new()
    {
        new Destination
        {
            Id = 1,
            Name = "Lalbagh Fort",
            Division = "Dhaka",
            District = "Dhaka",
            Category = "Historical",
            ImageUrl = "Images/lalbagh.png",
            Description = "17th-century Mughal fort complex standing proudly by the Buriganga River.",
            IdealDuration = "Half Day (4-5 Hours)",
            EstimatedCostPerPerson = 500,
            Activities = new() { "Historical Sightseeing", "Photography", "Museum Visit" }
        },
        new Destination
        {
            Id = 2,
            Name = "Cox's Bazar Sea Beach",
            Division = "Chattogram",
            District = "Cox's Bazar",
            Category = "Beach & Nature",
            ImageUrl = "https://images.unsplash.com/photo-1582650625119-3a31f8fa2699?w=800&auto=format&fit=crop",
            Description = "The longest natural unbroken sea beach in the world with golden sand and vibrant waves.",
            IdealDuration = "3 Days, 2 Nights",
            EstimatedCostPerPerson = 6500,
            Activities = new() { "Beach Walking", "Parasailing", "Marine Drive Tour", "Seafood Tasting" }
        },
        new Destination
        {
            Id = 3,
            Name = "Ratargul Swamp Forest",
            Division = "Sylhet",
            District = "Sylhet",
            Category = "Nature & Adventure",
            ImageUrl = "https://images.unsplash.com/photo-1596895111956-bf1cf0599ce5?w=800&auto=format&fit=crop",
            Description = "One of the few freshwater swamp forests in the world, famous for boat rides through submerged trees.",
            IdealDuration = "2 Days, 1 Night",
            EstimatedCostPerPerson = 4500,
            Activities = new() { "Country Boat Ride", "Watchtower View", "Bird Watching" }
        },
        new Destination
        {
            Id = 4,
            Name = "Somapura Mahavihara (Paharpur)",
            Division = "Rajshahi",
            District = "Naogaon",
            Category = "Historical",
            ImageUrl = "Images/paharpur.png",
            Description = "UNESCO World Heritage Site and one of the most famous Buddhist Viharas in the Indian Subcontinent.",
            IdealDuration = "1 Day",
            EstimatedCostPerPerson = 2000,
            Activities = new() { "Archaeological Exploration", "Museum Tour", "Photography" }
        },
        new Destination
        {
            Id = 5,
            Name = "Sundarbans Mangrove Forest",
            Division = "Khulna",
            District = "Bagerhat / Khulna",
            Category = "Wildlife & Nature",
            ImageUrl = "https://images.unsplash.com/photo-1544735716-392fe2489ffa?w=800&auto=format&fit=crop",
            Description = "The largest mangrove forest in the world and home to the Royal Bengal Tiger.",
            IdealDuration = "3 Days, 2 Nights",
            EstimatedCostPerPerson = 9500,
            Activities = new() { "Ship Cruise", "Canal Boat Safari", "Wildlife Spotting", "Karamjal Eco-Park" }
        }
    };

    public List<TourPackage> GetPackages() => new()
    {
        new TourPackage
        {
            Id = 101,
            PackageName = "Sylhet Nature & Tea Garden Escape",
            Division = "Sylhet",
            Duration = "3 Days, 2 Nights",
            PricePerPerson = 5500,
            ImageUrl = "https://images.unsplash.com/photo-1596895111956-bf1cf0599ce5?w=800&auto=format&fit=crop",
            IncludedFeatures = new() { "AC Bus Ticket", "3-Star Resort", "Breakfast & Dinner", "Boat Ride Fees" }
        },
        new TourPackage
        {
            Id = 102,
            PackageName = "Cox's Bazar & Saint Martin Combo",
            Division = "Chattogram",
            Duration = "4 Days, 3 Nights",
            PricePerPerson = 8500,
            ImageUrl = "https://images.unsplash.com/photo-1582650625119-3a31f8fa2699?w=800&auto=format&fit=crop",
            IncludedFeatures = new() { "Sleeper Coach", "Beachfront Hotel", "Ship Ticket", "All Meals" }
        }
    };
}