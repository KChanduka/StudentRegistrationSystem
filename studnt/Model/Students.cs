using System.ComponentModel.DataAnnotations;

namespace studnt.Model
{
    public class Students
    {
        [Key]
        public int Id { get; set; }
        public string? SFirstName { get; set; }
        public string? SSecondName { get; set; }

        
        public string? SRegistrationNumbrer { get; set; }

        public string ? SAcadenicYear { get; set; }
    }
}