using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatekApp.modele
{
    public class Motif
    {
        public int IdMotif { get; }
        public string Libelle { get; }

        public Motif(int id, string libelle)
        {
            IdMotif = id;
            Libelle = libelle;
        }

        public override string ToString()
        {
            return Libelle;
        }
    }
}
