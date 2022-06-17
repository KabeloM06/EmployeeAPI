namespace EmployeeAPI.Models
{
    public class Card
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
}
