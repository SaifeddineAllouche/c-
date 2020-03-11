using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_TP1
{
  public  class Ouvrier : Employee
    {
        public DateTime dateentree { get; set; }
        private static double _smig = 250;
        public static double SMIG
        {
            get { return _smig; }
        }
        public Ouvrier(int m,string n,string p,DateTime dn,DateTime de): base(m,n,p,dn)
        {
            dateentree = de;
        }

        public override double GetSalaire()
        {
            double salaire;
            int Anciennete = DateTime.Now.Year - dateentree.Year;
            if (dateentree.AddYears(Anciennete) > DateTime.Now.Date)
                Anciennete--;
            if (_smig + Anciennete * 100 <= 2 * _smig)
                salaire = _smig + Anciennete * 100;
            else
                salaire = 2 * _smig;
            return salaire;
              
        }
        public override string ToString()
        {
            return "Ouvrier : " + " " +base.ToString()+"Date d'entrer: " + dateentree.ToShortDateString();
        }

    }
}
