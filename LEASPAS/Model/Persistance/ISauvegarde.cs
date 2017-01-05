using System;
using System.IO;

namespace LEASPAS.Model.Persistance
{
    public interface ISauvegarde
    {
        /// <summary>
        /// Permet de réaliser une sauvegarde de la collection à l'emplacement souhaité
        /// </summary>
        /// <param name="path"></param>
        /// <param name="collection"></param>
        void Sauvegarder(string path, Collection collection);

        /// <summary>
        /// Permet de charger une collection à partir de l'emplacement passé en paramètre
        /// </summary>
        /// <returns></returns>
        Collection Charger(string path);
    }
}