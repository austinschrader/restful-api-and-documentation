using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BusinessApi.Models
{
  public class Shop
  {
    public int ShopId { get; set; }

    [Required]
    [Range(1, 3, ErrorMessage = "Pricing must be on a 1-3 scale.")]
    public int Pricing { get; set; }

    [Required]
    [StringLength(10, ErrorMessage = "Description must be less than 10 characters")]
    public string Description { get; set; }
  }
}