using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatekApp.modele
{
    public class Absence
    {
        public Personnel Personnel { get; }
        public DateTime DateDebut { get; }
        public DateTime DateFin { get; }
        public Motif Motif { get; }

        public Absence(Personnel personnel, DateTime datedebut, DateTime datefin, Motif motif)
        {
            Personnel = personnel;
            DateDebut = datedebut;
            DateFin = datefin;
            Motif = motif;
        }
    }
}
