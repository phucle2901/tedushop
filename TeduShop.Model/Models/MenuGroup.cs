
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TeduShop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
      public int ID {get;set;}
      [Required]
       [MaxLength(50)]
      public string Name{get;set;}  
      public virtual IEnumerable<Menu> Menus {get;set;}
    }
}