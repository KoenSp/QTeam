using System;
using System.Collections.Generic;
using System.Text;

namespace QTeam_DTO
{
    public class QTeamForm_DTO
    { 
        public int Id { get; set; }
        public string Geslacht { get; set; }
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public string Nummerplaat { get; set; }
        public string Email { get; set; }
        public string Straat { get; set; }
        public int Nummer { get; set; }
        public string Bus { get; set; }
        public string Stad { get; set; }
        public string Postcode { get; set; }
        public string Telefoon { get; set; }
        public bool Nieuwsbrief { get; set; }
    }
}
