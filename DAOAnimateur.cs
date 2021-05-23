using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PPE_Maison_Des_Ligues
{
    public class DAOAnimateur
    {
        public static List<Animateur> GetAllAnimateurs()
        {
            List<Animateur> lesAnimateurs = new List<Animateur>();
            string requete = "Select id,nom from participant where idtype = 2";
            DAOFactory daoP = new DAOFactory();
            daoP.connecter();
            
            SqlDataReader reader = daoP.excecSQLRead(requete);

            while (reader.Read())
            {
                Animateur anim = new Animateur(int.Parse(reader[0].ToString()), reader[1].ToString());
                lesAnimateurs.Add(anim);
            }
            return lesAnimateurs;
        }

        public static void setAnimateur(int idAtelier, int idAnimateur)
        {
            string requete = "update atelier set id_animateur" + idAnimateur + "where id=" + idAtelier;
            DAOFactory db = new DAOFactory();
            db.connecter();
            db.execSQLWrite(requete);
        }
    }
}