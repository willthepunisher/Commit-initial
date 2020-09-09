﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bourses.Outils
{
    class BDBase
    {
        private string ConnexionParam;
        private MySqlConnection MaConnexion;


        //private string Serveur = "localhost";
        //private string BaseDeDonnee = "bourse20";
        //private string MotDePasse = "";
        //private string Utilisateur = "root";

        public BDBase()
        {
            ConnexionParam = ConfigurationManager.ConnectionStrings["connexionBourse20"].ConnectionString;
            //ConnexionParam = "server=" + Serveur + ";database=" + BaseDeDonnee + ";uid=" + Utilisateur + ";password=" + MotDePasse +";Convert zero datetime=true; sslmode=none";
            try
            {
                MaConnexion = new MySqlConnection(ConnexionParam);
                MaConnexion.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Impossible de se connecter :" + e.Message);
                throw;
            }
            MessageBox.Show("Instaciation correct");
        }

        public DataSet Selection(string req)
        {
            DataSet resultat = new DataSet();

            try
            {
                if (Ouvrir())
                {
                    MySqlDataAdapter adapteur = new MySqlDataAdapter();
                    adapteur.SelectCommand = new MySqlCommand(req, MaConnexion);
                    adapteur.Fill(resultat);
                    return resultat;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erreur:" + e.Message);
                throw;
            }
            finally
            {
                Fermer();
            }

            return null;
        }

        public int Commande(string requete)
        {
            int nbResultat = 0;
            try
            {
                if (Ouvrir())
                {
                    MySqlCommand CMD = new MySqlCommand(requete, MaConnexion);
                    nbResultat = CMD.ExecuteNonQuery();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erreur dans la commande :" + e.Message);
                throw;
            }
            finally
            {
                Fermer();
            }
            return nbResultat;
        }

        private bool Ouvrir()
        {
            try
            {
                if (MaConnexion.State == System.Data.ConnectionState.Open)
                    return true;

                MaConnexion.Open();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erreur d'ouverture :" + e.Message);
                throw;
            }
        }

        private bool Fermer()
        {
            try
            {
                if (MaConnexion.State == System.Data.ConnectionState.Closed)
                    return true;

                MaConnexion.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erreur de fermeture :" + e.Message);
                throw;
            }
        }

    }
}
