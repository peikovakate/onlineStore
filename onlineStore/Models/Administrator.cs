using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onlineStore.Models
{
    public class Administrator
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public int IsConfirmed{ get; set; }
    }
}
