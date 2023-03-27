using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinDa_InfoTest
{
    internal class LinDa_Lavoratore : LinDa_Candidato
    {
        private int LinDa_esperienze;

        public int LinDa_Esperienze
        {
            get { return LinDa_esperienze; }
            private set {
                if (value >= 0 && value <= 5)
                    LinDa_esperienze = value;
                else throw new Exception();
            }
        }
        public LinDa_Lavoratore() : base()
        {
            LinDa_Esperienze = 0;
        }
        public LinDa_Lavoratore(int matricola, string nome, int esperienze) : base(matricola, nome)
        {
            LinDa_Esperienze = esperienze;
        }
        public override bool isIdoneo()
        {
            if (punteggio() >= 60)
                return true;
            else return false;
        }
        public override int punteggio()
        {
            return LinDa_Esperienze * 20;
        }

    }
}
