﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentManager.Models
{
    public class SignUpModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DocumentType DocumentType { get; set; }
        public string Document { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string AccessId { get; set; }
    }
}
