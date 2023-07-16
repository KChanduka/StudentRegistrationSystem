using System.ComponentModel.DataAnnotations;

namespace studnt.Model
{
    public class Instructors
    {
        //setting the id as the key and the id will self created
        [Key]
        public int Id { get; set; }
        public string ?IFirstName { get; set; }
        public string? ISecondName { get; set; }
        public string? IInstructorCode { get; set; }

        public string? IModuleCode { get; set; }

    }
}