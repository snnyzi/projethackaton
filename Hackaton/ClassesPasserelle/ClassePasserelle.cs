using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Hackaton
{
    public static partial class ClassePasserelle
    {
        private static string nomServeur = Properties.Resources.ResourceManager.GetObject("leServeur").ToString();
        private static string nomBDD = Properties.Resources.ResourceManager.GetObject("laBdd").ToString();
        private static string nomUtilisateur = Properties.Resources.ResourceManager.GetObject("leUser").ToString();
        private static string motDePasse = Properties.Resources.ResourceManager.GetObject("leMdp").ToString();

        private static string chaineConnexion = $"Data Source={nomServeur}; Initial Catalog={nomBDD}; user Id = {nomUtilisateur}; password = {motDePasse}";

    }
}
