using System.Collections.Generic;
using System.Data.SqlClient;

namespace PPE_Maison_Des_Ligues
{
    public class DAOTheme
    {
        public static List<Theme> GetThemesById(int idAtelier)
        {
            List<Theme> lesThemesById = new List<Theme>();
            string requete = "select id, libelle from theme where id_atelier ="+ idAtelier;
            DAOFactory daoP = new DAOFactory();
            daoP.connecter();

            SqlDataReader reader = daoP.excecSQLRead(requete);

            while (reader.Read())
            {
                Theme theme = new Theme(int.Parse(reader[0].ToString()), reader[1].ToString());
                lesThemesById.Add(theme);
            }

            return lesThemesById;
        }
    }
}