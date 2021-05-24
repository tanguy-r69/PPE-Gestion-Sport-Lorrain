using System.Collections.Generic;
using System.Data.SqlClient;

namespace PPE_Maison_Des_Ligues
{
    public class DAOIntervenant
    {
        public static List<Intervenant> GetIntervenants()
        {
            List<Intervenant> lesIntervenants = new List<Intervenant>();
            string requete = "Select id,nom from participant where idtype = 2";

            DAOFactory daoP = new DAOFactory();
            daoP.connecter();

            SqlDataReader reader = daoP.excecSQLRead(requete);

            while (reader.Read())
            {
                Intervenant inte = new Intervenant(int.Parse(reader[0].ToString()), reader[1].ToString());
                lesIntervenants.Add(inte);
            }

            return lesIntervenants;
        }

        public static void ajouterIntervenant(int idAtelier, int idIntervenant)
        {
            string requete = "If Not Exists(select id, id_atelier from intervenant where id=" + idIntervenant + " AND id_atelier=" + idAtelier +") " +
                             "Begin insert into intervenant values (" + idIntervenant + "," + idAtelier + ") End";
            
            DAOFactory daoP = new DAOFactory();
            daoP.connecter();
            SqlDataReader reader = daoP.excecSQLRead(requete);
        }

        public static List<Intervenant> intervenantByIdAtelier(int idAtelier)
        {
            List<Intervenant> intervenantById = new List<Intervenant>();
            string requete = "select participant.id,nom from intervenant join participant on intervenant.id = participant.id where id_atelier ="+ idAtelier;
            
            DAOFactory daoP = new DAOFactory();
            daoP.connecter();

            SqlDataReader reader = daoP.excecSQLRead(requete);

            while (reader.Read())
            {
                Intervenant inte = new Intervenant(int.Parse(reader[0].ToString()), reader[1].ToString());
                intervenantById.Add(inte);
            }

            return intervenantById;
        }
    }
    
    
}