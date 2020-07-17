using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataService.Models
{
    public  class Product
    {

      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public Guid ProductId { get; set; }

      [Required]
      [MaxLength(200)]
      public string ProductName { get; set; }

     [Required]
     [MaxLength(200)]
     public string Brand { get; set; }

    }
}
