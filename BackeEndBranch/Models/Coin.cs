using System.ComponentModel.DataAnnotations;

namespace BackeEndBranch.Models
{
    public class Coin
    {
        [Key]
        public int IdCoin { get; set; }
        [Required(ErrorMessage = "The field {0} es required '.'")]
        public string? NameCoin { get; set; }
        [Required(ErrorMessage = "The field {0} es required '.'")]
        public string? DescriptionCoin { get; set; }
        public bool StateCoin { get; set; }
    }
}
