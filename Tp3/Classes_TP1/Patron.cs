using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_TP1
{
    class Patron : Employee
    {
        public double ca { get; set; }
        public double pourcentage { get; set; }
        public Patron(int matricule, String nom, String prenom, DateTime dn,double ca,double p) :base(matricule, nom, prenom, dn)
        {
            this.ca = ca;
            this.pourcentage = p;
        }
        public override string ToString()
        {
            return "Patron: " + " " + base.ToString() + "Pourcentage" + pourcentage+"%";
        }

        public override double GetSalaire()
        {
            return Math.Round((ca * pourcentage / 100) / 12, 2); 
        }
    }
}
