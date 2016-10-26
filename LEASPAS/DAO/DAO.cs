using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace LEASPAS.DAO {
    public abstract class DAO<T>
    {
        /// <summary>
        /// Connection à la base SQLite pour éffectuer les transaction
        /// <remarks>À terme, le pattern de singleton pour gérer la connection
        /// sera à remettre en cause (particulièrement parce qu'il n'est pas
        /// Thread Safe)</remarks>
        /// </summary>
        public SQLiteConnection Connection { get; set; } = DatabaseConnection.GetInstance();
        /// <summary>
        /// Permet de créer un objet dans la table lui correspondant, 
        /// ainsi que dans les tables éventuellements associées à ses 
        /// relations.
        /// </summary>
        /// <param name="obj">Objet à ajouter dans la base de données</param>
        public abstract void Create(T obj);

        /// <summary>
        /// Permet de trouver l'entrée (dans la base associé au type)
        /// qui porte l'ID passé en paramètre.
        /// </summary>
        /// <param name="ID">ID de l'objet à trouver dans la base de données</param>
        /// <returns>null si l'objet n'a pas été trouver (oui c'est mal...)
        /// et construit une instance si l'objet existe dans la base</returns>
        public abstract T Find(int ID);

        /// <summary>
        /// Permet de mettre à jour l'objet passé en paramètre dans la
        /// base de données.
        /// </summary>
        /// <param name="obj">Objet à mettre à jour dans la base de données</param>
        public abstract void Update(T obj);

        /// <summary>
        /// Permet de supprimer l'objet passé en paramètre dans la base
        /// de données
        /// </summary>
        /// <param name="obj">Objet à supprimer dans la base de données</param>
        public abstract void Delete(T obj);
    }
}
