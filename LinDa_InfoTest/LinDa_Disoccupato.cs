using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinDa_InfoTest
{
    public class LinDa_Disoccupato : LinDa_Candidato
    {
        private int LinDa_voto;
        private bool LinDa_lode;

        public int LinDa_Voto
        {
            get { return LinDa_voto; }
            private set 
            {
                if (value >= 0 && value <= 110)
                    LinDa_voto = value;
                else throw new Exception("Valore fuori dal range");
            }
        }
        public bool LinDa_Lode
        {
            get { return LinDa_lode; }
            private set
            {               
                LinDa_lode = value;
            }
        }
        public LinDa_Disoccupato() : base()
        {
            LinDa_voto = 0;
            LinDa_lode = false;
        }
        
        public LinDa_Disoccupato(int matricola, string nome, int linDa_voto, bool linDa_lode) : base (matricola, nome)
        {
            LinDa_voto = linDa_voto;
            LinDa_lode = linDa_lode;           
        }


        public override bool isIdoneo()
        {
            if (punteggio() >= 72)
                return true;
            else return false;
        }
        public override int punteggio()
        {
            int val = LinDa_Voto * 91 / 100;
            if (LinDa_Lode)
                return val + 5;
            else 
                return val;
        }
    }
}
