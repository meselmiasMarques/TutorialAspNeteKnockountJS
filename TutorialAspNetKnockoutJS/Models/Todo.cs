namespace TutorialAspNetKnockoutJS.Models
{
    public class Todo
    {
        public Guid Id { get; set; } = new Guid();
        public string Title { get; set; } = string.Empty;
        public bool IsDone { get; set; } = false;

    }
}
