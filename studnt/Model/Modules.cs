using System.ComponentModel.DataAnnotations;

namespace studnt.Model
{
    public class Modules
    {
        [Key]
        public int Id { get; set; }
        public string? Modulename { get; set; }
        public string? ModuleCode { get; set; }
    }
}