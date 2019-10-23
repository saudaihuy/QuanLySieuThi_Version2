﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLySieuThi_Version2.Models
{
    class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public bool Gender { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(100)]
        [Index(IsUnique = true)]
        public string Name1 { get; set; }

        [Phone]
        [Required]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        


    }
}
