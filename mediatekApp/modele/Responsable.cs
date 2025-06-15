using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatekApp.modele
{
    public class Responsable
    {
        public string Login { get; }
        public string Pwd { get; }

        public Responsable(string login, string pwd)
        {
            Login = login;
            Pwd = pwd;
        }
    }
}
