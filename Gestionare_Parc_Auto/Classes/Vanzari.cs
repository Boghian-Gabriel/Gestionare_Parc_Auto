using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionare_Parc_Auto.Classes
{
    class Vanzari
    {
        public int Id_vanzari { get; set; }
        public int Id_auto_V { get; set; }

        public int Id_clienti_v { get; set; }

        public DateTime Data_vanzare { get; set; }

    }
}
