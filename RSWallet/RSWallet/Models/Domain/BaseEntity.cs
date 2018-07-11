using System;
using System.ComponentModel.DataAnnotations;

namespace RSWallet.Models
{
    public interface IBaseEntity
    {
        Guid ID { get; set; }
        bool IsDeleted { get; set; }
        DateTime CreateAt { get; set; }
        Guid? CreateBy { get; set; }
        DateTime? UpdateAt { get; set; }
        Guid? UpdateBy { get; set; }
    }

    public class BaseEntity: IBaseEntity
    {
        [Required]
        public Guid ID { get; set; }
        public bool IsDeleted { get; set; }
        [Required]
        public DateTime CreateAt { get; set; }
        public Guid? CreateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public Guid? UpdateBy { get; set; }
    }
}