﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoscS_InfoTest
{
    public abstract class MoscS_Disoccupato : MoscS_Candidato
    {
        private int _MoscS_voto;
        private bool _MoscS_lode;


        public int MoscS_voto
        {
            set
            {
                if (value <= 110 && value >=0)
                    _MoscS_voto = value;
                else
                    throw new Exception("Voto non valido");
            }

            get
            {
                return _MoscS_voto;
            }
        }
        public bool MoscS_lode
        {
            set
            {
                _MoscS_lode = value;
            }

            get
            {
                return _MoscS_lode;
            }
        }


        public MoscS_Disoccupato(): base()
        {
            MoscS_voto = 0;
            MoscS_lode = false;
        }


        public MoscS_Disoccupato(string nome, int matricola, int voto, bool lode): base(nome, matricola)
        {
            MoscS_voto = voto;
            MoscS_lode = lode;
        }


        public override int punteggio()
        {
            int x = MoscS_voto * 100 / 110;

            if (MoscS_lode)
                x += 5;

            return x;
        }


        public override bool isIdoneo()
        {
            if (punteggio() >= 72)
                return true;
            else
                return false;
        }
    }
}
