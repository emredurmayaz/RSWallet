using System;
using System.ComponentModel.DataAnnotations;

namespace RSWallet.Models
{
    public class Sector : BaseEntity, IBaseEntity
    {
        [Required, MaxLength(20)]
        public string Code { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
    }
}