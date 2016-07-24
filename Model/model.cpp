#include "model.h"

#include <QDebug>
#include <QMessageBox>

Model::Model(QStatusBar* stb)
{
    statusBar = stb;
    initDb();
}

void Model::addEleve(QString nom, QString prenom)
{
    QString sReq = "INSERT INTO eleve (nom, prenom, motifs) VALUES ('" + nom + "', '" + prenom + "', '00000000000000')";
    QSqlQuery query(sReq);
    QMessageBox::information(NULL, "Succès", "L'élève a été ajouté avec succès.");
}

void Model::verifyStruct()
{
    if(!QDir("Logs").exists()) QDir().mkdir("Logs");
    QFile bddLog("Logs\\BDDLog.txt");
    bddLog.open(QIODevice::Append | QIODevice::Text);
    QTextStream bddLogStream(&bddLog);

    QSqlQuery query("SELECT COUNT(*) FROM sqlite_master WHERE type = 'table'");
    query.exec();
    query.next();
    //if(query.value(0).toInt() < 9 ){ // 8 tables pour le soft + celles des séquences SQLite

    /*
     * Il faut trouver un moyen de vérifier si la structure est différente de manière plus propore
     * qu'en comparant le nombre de table dans la base c'est sans faire beaucoup de requêtes ^^
     */

        QSqlQuery itQuery(connection);
        QFile scriptFile("Script\\databaseInitialStructure.sql");
        if (scriptFile.open(QIODevice::ReadOnly))
        {
            QStringList scriptQueries = QTextStream(&scriptFile).readAll().split(';'); // On sépare les différentes requêtes

            foreach (QString queryTxt, scriptQueries)
            {
                if (queryTxt.trimmed().isEmpty()) {
                    continue;
                }
                if (!itQuery.exec(queryTxt))
                {
                    bddLogStream << itQuery.lastError().text();
                    bddLogStream << '\n';
                }
                itQuery.finish();
            }
        }
    //}
        bddLog.flush();
        bddLog.close();
}

void Model::initDb(){
    if(!QDir("Data").exists()) QDir().mkdir("Data");
    connection = QSqlDatabase::addDatabase("QSQLITE");
    connection.setDatabaseName("Data/database.db");

    if(connection.open()){
        verifyStruct();
        message = "Prêt (connecté à : " + connection.databaseName() + ")";
        statusBar->showMessage(message);

    }else{
        message = "Erreur de connexion à la BDD : " + connection.lastError().text();
        QMessageBox::critical(NULL, "Erreur BDD", message);
        statusBar->showMessage(message);
    }

}
