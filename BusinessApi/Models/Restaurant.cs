using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BusinessApi.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }

    [Required]
    [DisplayName("Enter the Restaurant's name")]
    public string Name { get; set; }

    [Required]
    [DisplayName("Enter the Restaurant's pricing")]
    [Range(1, 3, ErrorMessage = "Pricing must be on a 1-3 scale.")]
    public int Pricing { get; set; }
  }
}