namespace MyPortfolio.Net6.Pages
{
    public partial class Index
    {
        public List<Project> Projects { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            Projects = await GetRecentProjectsAsync();
        }

        private Task<List<Project>> GetRecentProjectsAsync()
        {
            var data = new List<Project>
            {
                new() { Name = "Survey Builder App", Description = "Dynamic nested survey creation using Blazor components." },
                new() { Name = "SSRS Viewer", Description = "Blazor UI that mimics the SSRS ReportViewer using only ReportExecution SOAP API." }
            };

            return Task.FromResult(data);
        }

        public class Project
        {
            public string Name { get; set; } = default!;
            public string Description { get; set; } = default!;
        }
    }
}
