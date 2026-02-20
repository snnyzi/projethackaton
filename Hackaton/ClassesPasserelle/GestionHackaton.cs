using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton
{
    public static partial class ClassePasserelle
    {
        /// <summary>
        /// Obtient la liste des campings présents dans la base de données
        /// </summary>
        /// <returns> Liste d'instances de Camping </returns>
        public static List<Hackaton> GetLesHackatons()
        {
            SqlConnection connexionBase = new SqlConnection(chaineConnexion);
            List<Hackaton> lesHackatons = new List<Hackaton>();
            SqlCommand reqGet = new SqlCommand("select " +
                "idHackaton, " +
                "theme, " +
                "nomLieu, " +
                "ville, " +
                "dateHeureDebut, " +
                "dateHeureFin, " +
                "nbPlacesMax, " +
                "dateLimiteAjoutDefi, " +
                "dateLimiteInscription " +
                "" +
                "from Hackaton", connexionBase);
            try
            {
                connexionBase.Open();
                SqlDataReader readerReqGet = reqGet.ExecuteReader();
                while (readerReqGet.Read())
                {
                    lesHackatons.Add(new Hackaton(
                        Convert.ToInt32(readerReqGet[0]), 
                        readerReqGet[1].ToString(), 
                        readerReqGet[2].ToString(), 
                        readerReqGet[3].ToString(), 
                        Convert.ToDateTime(readerReqGet[4]),
                        Convert.ToDateTime(readerReqGet[5]),
                        Convert.ToInt32(readerReqGet[6]),
                        Convert.ToDateTime(readerReqGet[7]),
                        Convert.ToDateTime(readerReqGet[8]) ));
                }
            }
            finally
            {
                connexionBase.Close();
            }
            return lesHackatons;
        }
    }
}
