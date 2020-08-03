using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.ApplicationCore.Entities
{
    public class Client
    {
        public Client()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime date_of_birth { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; }

    }
}
