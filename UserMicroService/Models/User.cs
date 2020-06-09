using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserMicroService.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Filiere_Id { get; set; }
    }
}
