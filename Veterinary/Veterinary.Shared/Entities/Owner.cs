﻿namespace Veterinary.Shared.Entities
{
    public class Owner
    {

        public int Id { get; set; }
        public string Document { get; set; }
        public string FirstName { get; set; }    

        public string LastName { get; set; }

        public string Email { get; set; }

        public string FixedPhone { get; set; }

        public string addres { get; set; }

        public string PhoneNumber { get; set; }

        public string FullName => $"{FirstName}{LastName}";


    }
}