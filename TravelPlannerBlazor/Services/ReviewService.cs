using System.Text.Json;
using TravelPlannerBlazor.Models;

namespace TravelPlannerBlazor.Services;

public class ReviewService
{
    private const string ReviewStorageKey = "user_travel_reviews";
    private List<TravelerReview> _reviews = new();

    public ReviewService()
    {
        LoadReviews();
    }

    public List<TravelerReview> GetAllReviews() => _reviews.OrderByDescending(r => r.DatePosted).ToList();

    public void AddReview(TravelerReview review)
    {
        if (string.IsNullOrWhiteSpace(review.TravelerName) || string.IsNullOrWhiteSpace(review.Comment))
            return;

        review.DatePosted = DateTime.Now;
        _reviews.Add(review);
        SaveReviews();
    }

    private void SaveReviews()
    {
        var json = JsonSerializer.Serialize(_reviews);
        Preferences.Default.Set(ReviewStorageKey, json);
    }

    private void LoadReviews()
    {
        var json = Preferences.Default.Get(ReviewStorageKey, string.Empty);
        if (!string.IsNullOrEmpty(json))
        {
            _reviews = JsonSerializer.Deserialize<List<TravelerReview>>(json) ?? new();
        }

        if (_reviews.Count == 0)
        {
            _reviews.AddRange(new List<TravelerReview>
            {
                new TravelerReview { TravelerName = "Tanvir Ahmed", DestinationName = "Ratargul Swamp Forest", Rating = 5, Comment = "Monsoon boat ride through the submerged trees was magical! Highly recommend early morning visit.", DatePosted = DateTime.Now.AddDays(-3) },
                new TravelerReview { TravelerName = "Nusrat Jahan", DestinationName = "Shashi Lodge, Mymensingh", Rating = 4, Comment = "Very peaceful historical palace. Don't forget to try Muktagacha's famous Monda nearby!", DatePosted = DateTime.Now.AddDays(-1) }
            });
            SaveReviews();
        }
    }
}