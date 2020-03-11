using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_TP1
{
    public abstract class Employee : IEquatable<Employee>
    {
        public int Matricule { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public DateTime Datenaissance { get; set; }

        public Employee(int matricule, String nom, String prenom, DateTime dn)
        {
            this.Matricule = matricule;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Datenaissance = dn;
            
        }
        public override string ToString() {
            return "Matricule : " + Matricule + "Nom : " + Nom + "Prénom : " + Prenom + "Date de naissance : " + Datenaissance;
        }
        public abstract double GetSalaire();
        public bool Equals(Employee e)
        {

            return e.Matricule == Matricule;
        }
    }
}
