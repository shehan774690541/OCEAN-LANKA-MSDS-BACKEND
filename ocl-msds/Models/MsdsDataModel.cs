using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ocl_msds.Models
{
    [Table("msds")]
    public class MsdsDataModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? name { get; set; }

        [Required]
        public bool check {  get; set; }

        [Required]
        public string? file { get; set; }

        [Required]
        public string? department { get; set; }


    }
}
