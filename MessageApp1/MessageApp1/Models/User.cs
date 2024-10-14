using MessageApp1.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageApp1.Models
{
    public class User
    {
            public Guid Id { get; set; }
            public byte[]? Image { get; set; } = [];
            public string Color { get; set; } = string.Empty;
            public string NickName { get; set; } = string.Empty;
            public string Tag { get; set; } = string.Empty;
            public string? CustomStatus { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string PasswordHash { get; set; } = string.Empty;
            public string Salt { get; set; } = string.Empty;
            public DateTime CreationDate { get; set; }
            public DateTime LastActive { get; set; }
            public Statuses Status { get; set; }
            public bool IsDeleted { get; set; }
            public virtual ICollection<Chat> Chats { get; set; } = null!;

        [NotMapped]
        public string UserName => $"{NickName}#{Tag}";
        public string CreationDateFormated => CreationDate.ToString();
        public string LastActiveFormated => CreationDate.ToString();
        public string ImagePath { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

    }
}
