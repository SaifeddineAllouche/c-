using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace ClassADO
{
    class ProduitDAO
    {
        public void Inserer(Produit p)
        {
            SqlCommand cmdaj = new SqlCommand("insert into Produit(Ref_Prod,Desig_Prod,Categ_Prod,PrixV_Prod)values(@ref,@Desig,@Categ,@Prix)",Connexion.cn);
            cmdaj.Parameters.AddWithValue("@Ref", p.Ref_Prod);
            cmdaj.Parameters.AddWithValue("@Ref", p.Desig_Prod);
            cmdaj.Parameters.AddWithValue("@Ref", p.Categ_Prod);
            cmdaj.Parameters.AddWithValue("@Ref", p.PrixV_Prod);
            cmdaj.ExecuteNonQuery();
        }
        public static bool Existe_Produit(String Ref)
        {
            SqlCommand cverif = new SqlCommand("select * from Produit where Ref_Prod =@Ref");
            cverif.Parameters.AddWithValue("@Ref", Ref);
            SqlDataReader drverif = cverif.ExecuteReader();

            if (drverif.HasRows == true)
            {
                drverif.Close();
                return true;
            }
            else
            {
                drverif.Close();
                return false;
            }

        }
        public void Supprimer(string Ref)
        {
            SqlCommand cmdsupp = new SqlCommand("delete from Produit where Ref_Prod =@Ref",Connexion.cn);
            cmdsupp.Parameters.AddWithValue("@Ref", Ref);
            cmdsupp.ExecuteNonQuery();
        }
        public void Modifier(Produit p)
        {
            SqlCommand cmdmod = new SqlCommand("update Produit set Desig_Prod=@Desig,Categ_Prod=@Categ,PrixV_Prod=@Prix where Ref_Prod=@Ref", Connexion.cn);
            cmdmod.Parameters.AddWithValue("@Desig", p.Desig_Prod);
            cmdmod.Parameters.AddWithValue("@Categ", p.Categ_Prod);
            cmdmod.Parameters.AddWithValue("@Prix", p.PrixV_Prod);
            cmdmod.Parameters.AddWithValue("@Ref", p.Ref_Prod);
            cmdmod.ExecuteNonQuery();
        }
        public static DataTable Liste_Produit()
        {
            DataTable dtcl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Produit", Connexion.cn);
            da.Fill(dtcl);
            return dtcl;
        }
        public static DataTable Recherche_ParCateg(string Categ)
        {
            DataTable dtcl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Produit where Categ_Prod=@Categ ", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Categ", Categ);
            da.Fill(dtcl);
            return dtcl;
        }
        public static DataTable Recherche_ParRef(string Ref)
        {
            DataTable dtcl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Produit where Ref_Prod=@Ref ", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Ref", Ref);
            da.Fill(dtcl);
            return dtcl;
        }
        public static DataTable Recherche_ParDesig(string Desig)
        {
            DataTable dtcl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Produit where Desig_Prod=@Desig ", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Desig", Desig + '%');
            da.Fill(dtcl);
            return dtcl;
        }

    }
}
