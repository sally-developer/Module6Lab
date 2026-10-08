using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TeenHangout.Pages;

public class IndexModel : PageModel
{
    // Array of users
public User[] Users { get; } =
[
    new("MusicLover", 15, "Purple"),
    new("GamerGirl", 16, "Red"),
    new("BookwormBen", 15, "Yellow"),
    new("DanceQueen", 17, "Pink"),
    new("SoccerStar", 16, "Blue"),
    new("CoffeeQueen", 16, "Lavender")
];
    // Array of Posts

public Post[] Posts { get; } =
[
    new("GamerGirl", "🎮 Anyone want to play online later?", 30),
    new("BookwormBen", "📚 Reading the best fantasy book ever!", 15),
    new("MusicLover", "🎵 Concert next week! So excited!", 22),
    new("DanceQueen", "💃 Just learned a new dance routine!", 42),
    new("SoccerStar", "⚽ Won our match today!", 35),
    new("CoffeeQueen", "☕ Studying with iced coffee is the best!", 28)
];
  
}

