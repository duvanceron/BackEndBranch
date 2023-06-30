using System.ComponentModel.DataAnnotations;

namespace BackeEndBranch.Models
{
    public class Branch
    {
        [Key]
        public int CodeBranch { get; set; }
        [Required(ErrorMessage = "The field {0} es required '.'")]
        [StringLength(maximumLength: 250)]
        public string? DescriptionBranch { get; set; }
        [Required(ErrorMessage = "The field {0} es required '.'")]
        [StringLength(maximumLength: 250)]
        public string? AdressBranch { get; set; }
        [Required(ErrorMessage = "The field {0} es required '.'")]
        [StringLength(maximumLength: 50)]
        public string? IdentificationBranch { get; set; }
        public string? DateBranch { get; set; }
        public int FKMoneyBranch { get; set; }

    }
}
