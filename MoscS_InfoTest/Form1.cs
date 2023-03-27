using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoscS_InfoTest
{
    public partial class Form1 : Form
    {
        List<MoscS_Candidato> lista = new List<MoscS_Candidato>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void Aggiunta(MoscS_Candidato candidato)
        {
            if (candidato == null)
                throw new Exception("Candidato non valido"); 

            if (!lista.Contains(candidato))
                lista.Add(candidato);
            else
                throw new Exception("Candidato già presente");
        }


        public string[] Refresh()
        {
            string[] valori = new string[lista.Count()];
            for (int i=0; i<lista.Count(); i++)
            {
                valori[i] = lista[i].ToString();
            }

            return valori;
        }


        public void Modifica(MoscS_Candidato newCandidato)
        {
            int index = -1;

            for(int i=0; i<lista.Count(); i++)
            {
                if (newCandidato.MoscS_matricola== lista[i].MoscS_matricola)
                {
                    index = 1;
                    break;
                }
            }

            if (index != -1)
                lista[index] = newCandidato;
            else
                throw new Exception($"Candidato di matricola: {newCandidato.MoscS_matricola}, non è presente nella Lista");
        }


        public void Elimina(int matricola)
        {
            int index = -1;

            for (int i = 0; i < lista.Count(); i++)
            {
                if (matricola == lista[i].MoscS_matricola)
                {
                    index = 1;
                    break;
                }
            }

            if (index != -1)
                lista.RemoveAt(index);
            else
                throw new Exception($"Candidato di matricola: {matricola}, non è presente nella Lista");
        }


        public string[] CandidatiIdonei()
        {
            int valore = 0;
            for(int i=0; i< lista.Count(); i++)
            {
                if (lista[i].isIdoneo())
                {
                    valore++;
                }
            }
            string[] valori = new string[valore];
            for (int i = 0; i < lista.Count(); i++)
            {
                if (lista[i].isIdoneo())
                {
                    valori[i] = lista[i].ToString();
                }
            }

            return valori;
        }

        public void SortLista()
        {
            lista.Sort();
            //lista.OrderBy<>
        }
    }
}
