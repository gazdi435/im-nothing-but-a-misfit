using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kutyák
{
    internal class Kutyak
    {
        int id;
        string kutyaFajtaja;
        string kutyaNeve;
        int kutyaEletkora;
        string vizsgalatIdeje;

        public Kutyak(int id, string kutyaFajtaja, string kutyaNeve, int kutyaEletkora, string vizsgalatIdeje)
        {
            id = this.id;
            kutyaFajtaja = this.kutyaFajtaja;
            kutyaNeve = this.kutyaNeve;
            kutyaEletkora = this.kutyaEletkora;
            vizsgalatIdeje = this.vizsgalatIdeje;
        }


        public int Id { get => id; set => id = value; }
        public string KutyaFajtaja { get => kutyaFajtaja; set => kutyaFajtaja = value; }
        public string KutyaNeve { get => kutyaNeve; set => kutyaNeve = value; }
        public int KutyaEletkora { get => kutyaEletkora; set => kutyaEletkora = value; }
        public string VizsgalatIdeje { get => vizsgalatIdeje; set => vizsgalatIdeje = value; }
    }
}
