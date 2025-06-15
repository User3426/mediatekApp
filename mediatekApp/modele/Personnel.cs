using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatekApp.modele
{
    public class Personnel
    {
        public int IdPersonnel { get; }
        public string Nom { get; }
        public string Prenom { get; }
        public string Tel { get; }
        public string Mail { get; }
        public Service Service { get; }

        public Personnel(int id, string nom, string prenom, string tel, string mail, Service service)
        {
            IdPersonnel = id;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
            Mail = mail;
            Service = service;
        }
    }
}
