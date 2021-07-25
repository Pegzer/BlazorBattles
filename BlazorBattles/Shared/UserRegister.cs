using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorBattles.Shared {
    public class UserRegister {
        [Required, EmailAddress]
        public string Email { get; set; }
        [StringLength(16, ErrorMessage = "Your username is too long (16 characters max)")]
        public string Username { get; set; }
        public string bio { get; set; }
        [Required, StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int StartUnitId { get; set; } = 1;
        [Range(0, 1000, ErrorMessage = "Please choose a number between 0 & 1000.")]
        public int Bananas { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Range(typeof(bool), "true", "true", ErrorMessage = "Only confirmed users can play.")]
        public bool IsConfirmed { get; set; }
    }
}