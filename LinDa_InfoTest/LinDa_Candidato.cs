﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinDa_InfoTest
{
    public abstract class LinDa_Candidato : IEquatable<LinDa_Candidato>
    {
        private int LinDa_matricola;
        private string LinDa_nome;


        public int LinDa_Matricola {
            get { return LinDa_matricola; }
            private set { LinDa_matricola = value; }
        }
        public string LinDa_Nome
        {
            get { return LinDa_nome; }
            private set { LinDa_nome = value; }
        }


        public LinDa_Candidato()
        {
            LinDa_Matricola = 0;
            LinDa_Nome = "";           
        }
        public LinDa_Candidato(string nome)
        {
            LinDa_Matricola = 0;
            LinDa_Nome = nome;
        }
        public LinDa_Candidato(int matricola)
        {
            LinDa_Matricola = matricola;
            LinDa_Nome = "";
        }
        public LinDa_Candidato(int matricola, string nome)
        {
            LinDa_Matricola = matricola;
            LinDa_Nome = nome;
        }


        public abstract bool isIdoneo();        
        public abstract int punteggio();
        public virtual int CompareTo(LinDa_Candidato candidato)
        {
            return candidato.punteggio() - this.punteggio();
        }
        public virtual int HashCode()
        {
            return (LinDa_Matricola, LinDa_Nome).GetHashCode();
        }                  
        public override string ToString()
        {
            return LinDa_Matricola + ";" + LinDa_Nome;
        }
        public bool Equals(LinDa_Candidato cand)
        {
            if(cand == null)
                return false;
            if (this == cand)
                return true;
            if (this.LinDa_Nome == cand.LinDa_Nome && this.LinDa_Matricola == cand.LinDa_Matricola)
                return true;
            else return false;
        }
    }
}
