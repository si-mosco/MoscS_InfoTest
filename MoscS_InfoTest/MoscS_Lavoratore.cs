using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoscS_InfoTest
{
    public abstract class MoscS_Lavoratore: MoscS_Candidato, IEquatable<MoscS_Lavoratore>, IComparable<MoscS_Lavoratore>
    {
        private int _MoscS_esperienze;


        public int MoscS_esperienze
        {
            set
            {
                if (value <= 5 && value >= 0)
                    _MoscS_esperienze = value;
                else
                    throw new Exception("Valore esperienza non valida");
            }

            get
            {
                return _MoscS_esperienze;
            }
        }


        public MoscS_Lavoratore(): base()
        {
            MoscS_esperienze = 0;
        }


        public MoscS_Lavoratore(string nome, int matricola, int esperienze): base(nome, matricola)
        {
            MoscS_esperienze = esperienze;
        }


        public override int punteggio()
        {
            return (20 * 5);
        }


        public override bool isIdoneo()
        {
            return (punteggio() >= 60);
        }


        public override string ToString()
        {
            return base.ToString() + $";{MoscS_esperienze}";
        }


        public bool Equals(MoscS_Lavoratore other)
        {
            if (other == null)
                return false;

            if (this == other)
                return true;

            if (!base.Equals(other))
                return false;
            else
            {
                if (this.MoscS_esperienze != other.MoscS_esperienze)
                    return false;
            }

            return true;
        }


        public int CompareTo(MoscS_Lavoratore other)
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
    }
}
