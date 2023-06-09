﻿using System;
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
        public override string ToString()
        {
            return base.ToString() + ";" + LinDa_Esperienze;
        }
        public bool Equals(LinDa_Lavoratore lav)
        {
            if (this.LinDa_Esperienze == lav.LinDa_Esperienze)
                return base.Equals(lav);
            else return false;
        }
        public override int CompareTo(LinDa_Candidato candidato)
        {
            return base.CompareTo(candidato);
        }
        public override int HashCode()
        {
            return base.HashCode();
        }
    }
}
