using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatekApp.modele
{
    public class Service
    {
        public int IdService { get; }
        public string Nom { get; }

        public Service(int id, string nom)
        {
            IdService = id;
            Nom = nom;
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
