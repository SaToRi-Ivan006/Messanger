using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageApp1.Models
{
    public class Chat
    {
        public Chat() { }
        public Chat(string title, bool isGrooup) 
        {
            Id = new Guid();
            Title = title;
            CreationData = DateTime.Now;
            IsGroup = isGrooup;
            IsDeleted = false;
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreationData { get; set; }
        public bool IsGroup { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<User> Users { get; set; } = null!;
        public virtual ICollection<Message> Messages { get; set; } = null!;
    }
}
