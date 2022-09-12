namespace VisistorManagementSystem.Models
{
    public class Visitors
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        public string LastName{ get; set; }

        public String Business { get; set; }

        public DateTime DateIn { get; set; }

        public DateTime DateOut { get; set; }

        //Navigation

        public Guid StaffNameId { get; set; }   
        //Public StaffNames StaffName
        public StaffNames StaffName { get; set; }
    }
}
