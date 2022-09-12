namespace VisistorManagementSystem.Models
{
    public class StaffNames
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int VisitorCount { get; set; }
    }
}
