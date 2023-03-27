using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoscS_InfoTest
{
    public abstract class MoscS_Candidato: IEquatable<MoscS_Candidato>, IComparable<MoscS_Candidato>
    {
        private int _MoscS_matricola;
        private string _MoscS_nome;


        public int MoscS_matricola
        {
            get
            {
                return _MoscS_matricola;
            }
            set
            {
                _MoscS_matricola = value;
            }
        }
        public string MoscS_nome
        {
            get
            {
                return _MoscS_nome;
            }
            set
            {
                _MoscS_nome = value;
            }
        }


        public MoscS_Candidato()
        {
            MoscS_matricola = 0;
            MoscS_nome = null;
        }


        public MoscS_Candidato(int matricola)
        {
            MoscS_matricola = matricola;
            MoscS_nome = null;
        }
        public MoscS_Candidato(string nome)
        {
            MoscS_matricola = 0;
            MoscS_nome = nome;
        }


        public MoscS_Candidato(string nome, int matricola)
        {
            MoscS_matricola = matricola;
            MoscS_nome = nome;
        }


        public abstract bool isIdoneo();


        public abstract int punteggio();


        public override string ToString()
        {
            return $"{MoscS_matricola};{MoscS_nome}";
        }


        public bool Equals(MoscS_Candidato other)
        {
            if (other == null) 
                return false;

            if (this == other)
                return true;

            if (this.MoscS_matricola != other.MoscS_matricola)
                return false;
            if (this.MoscS_nome != other.MoscS_nome)
                return false;

            return true;
        }


        public int CompareTo(MoscS_Candidato other)
        {
            if (other == null)
                return 1;

            if (this.punteggio() == other.punteggio())
                return 0;
            else if (this.punteggio() < other.punteggio())
                return -1;
            else
                return 1;
        }


        public override int GetHashCode() => (this.MoscS_matricola, this.MoscS_nome).GetHashCode();
    }
}