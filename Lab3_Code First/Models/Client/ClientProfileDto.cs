﻿namespace Lab3_Code_First.Models.Client
{
    public class ClientProfileDto
    {
        public Guid Id { get; set; }

        public string NickName { get; set; }

        public string Password { get; set; }

        public DateTime RegistrationDate { get; set; }

    }
}
