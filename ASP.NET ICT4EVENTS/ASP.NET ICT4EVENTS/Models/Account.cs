﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class Account
    {
        public int Id_Account { get; set; }
        public string Gebruikersnaam { get; set; }
        public string Email { get; set; }
        public string ActivatieHash { get; set; }
        public bool Geactiveerd { get; set; }

        public Account(int id_account, string gebruikersnaam, string email, string activatieHash)
        {
            Id_Account = id_account;
            Gebruikersnaam = gebruikersnaam;
            Email = email;
            ActivatieHash = activatieHash;
            Geactiveerd = false;
        }
        
    }
}