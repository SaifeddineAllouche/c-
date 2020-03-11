using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_TP1
{
    internal class Cadre : Employee
    {
        public int indice { get; set; }
        public Cadre(int matricule, String nom, String prenom, DateTime dn, int indice) : base(matricule, nom, prenom, dn)
        {
            this.indice = indice;
        }
        public override string ToString()
        {
            return "Cader: " + " " + base.ToString() + "indice" + indice;
        }
        public override double GetSalaire()
        { double salaire =0 ;
            switch (indice)
            { 
                case 1:
                     salaire = 1300;
                    break;

                case 2:
                     salaire = 1500;
                    break;
                case 3:
                     salaire = 1700;
                    break;
                case 4:
                     salaire = 2000;
                    break;

            } return salaire;
        }
       
    }
}
