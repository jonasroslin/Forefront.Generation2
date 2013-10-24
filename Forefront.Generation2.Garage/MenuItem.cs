namespace Forefront.Generation2.Garage
{
    public class MenuItem
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public MenuItem(string title)
        {
            Title = title;
            Description = string.Empty;
        }
    }
}