using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoscS_InfoTest
{
    public abstract class MoscS_Lavoratore: MoscS_Candidato
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
    }
}
