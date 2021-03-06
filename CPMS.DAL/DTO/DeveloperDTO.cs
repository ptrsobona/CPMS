﻿using CPMS.DAL.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPMS.DAL.DTO
{
    [Table("Developers", Schema = "pms")]
    public class DeveloperDTO
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }


        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        [Required]
        public Role Role { get; set; }
    }
}
