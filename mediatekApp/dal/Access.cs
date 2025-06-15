using mediatekApp.bdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatekApp.dal
{
    /// <summary>
    /// classe d'accès à BddManager
    /// </summary>
    class Access
    {
        private static readonly string connectionString = "server=localhost;user id=mediatekuser;password=Sio1234*;database=mediatek;";

        private static Access instance = null;
        public BddManager Manager { get; }

        private Access()
        {
            try
            {
                Manager = BddManager.GetInstance(connectionString);
            }
            catch
            {
                Environment.Exit(0);
            }
        }

        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }
    }
}
