using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TutorialWebApp.Pages;

public class ExamplesModel : PageModel
{
    private readonly ILogger<ExamplesModel> _logger;

    public ExamplesModel(ILogger<ExamplesModel> logger)
    {
        _logger = logger;
    }

    public string CurrentTime { get; set; } = string.Empty;
    public List<string> DotNetFeatures { get; set; } = new();
    public int RandomNumber { get; set; }

    public void OnGet()
    {
        CurrentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        
        DotNetFeatures = new List<string>
        {
            "跨平台開發支援",
            "高效能執行時期",
            "現代化的 C# 語言",
            "豐富的類別庫",
            "雲端優化",
            "開源且免費"
        };

        RandomNumber = Random.Shared.Next(1, 101);
        
        _logger.LogInformation("Examples page visited at {Time}", CurrentTime);
    }
}
