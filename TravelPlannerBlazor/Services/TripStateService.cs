using System.Text.Json;
using TravelPlannerBlazor.Models;

namespace TravelPlannerBlazor.Services;

public class TripStateService
{
    private const string StorageKey = "saved_user_trips";
    private List<Trip> _savedTrips = new();

    public TripStateService()
    {
        LoadTripsFromStorage();
    }

    public List<Trip> GetSavedTrips() => _savedTrips;

    public void AddTrip(string title, string location)
    {
        if (string.IsNullOrWhiteSpace(title)) return;

        if (!_savedTrips.Any(t => t.Title.Equals(title, StringComparison.OrdinalIgnoreCase)))
        {
            _savedTrips.Add(new Trip { Title = title, Location = location });
            SaveTripsToStorage();
        }
    }

    public void RemoveTrip(Trip trip)
    {
        _savedTrips.Remove(trip);
        SaveTripsToStorage();
    }

    private void SaveTripsToStorage()
    {
        var json = JsonSerializer.Serialize(_savedTrips);
        Preferences.Default.Set(StorageKey, json);
    }

    private void LoadTripsFromStorage()
    {
        var json = Preferences.Default.Get(StorageKey, string.Empty);
        if (!string.IsNullOrEmpty(json))
        {
            _savedTrips = JsonSerializer.Deserialize<List<Trip>>(json) ?? new();
        }
    }
}