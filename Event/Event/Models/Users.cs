﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Event.Models
{
    public class Users
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        public virtual ICollection<Events> EventsList { get; set; }
    }
}