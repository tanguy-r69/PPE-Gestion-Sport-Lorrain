using System.Collections.Generic;
using System.Data.SqlClient;

namespace PPE_Maison_Des_Ligues
{
    public class DAOTheme
    {
        public static List<Theme> GetAllThemes()
        {
            List<Theme> lesThemes = new List<Theme>();
            string requete = "select * from theme";
            DAOFactory daoP = new DAOFactory();
            daoP.connecter();

            SqlDataReader reader = daoP.excecSQLRead(requete);

            while (reader.Read())
            {
                Theme theme = new Theme(int.Parse(reader[0].ToString()), reader[1].ToString(),
                    int.Parse(reader[2].ToString()));
                lesThemes.Add(theme);
            }

            return lesThemes;
        }
    }
}