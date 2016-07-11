#include "model.h"

#include <QDebug>

Model::Model(QStatusBar* stb)
{
    statusBar = stb;
    initDb();
}

void Model::initDb(){
    connection = QSqlDatabase::addDatabase("QSQLITE");
    connection.setDatabaseName("Data/database.db");


    if(connection.open()){
        QSqlQuery query("SELECT * FROM sqlite_master WHERE type = 'table' AND name = 'Eleve'");
        query.exec();
        query.next();
        if(query.value(0).toInt() == 0){
            query.clear();
            query.prepare("DROP TABLE Eleve");
            query.exec();

            query.clear();
            query.prepare("CREATE TABLE Eleve (id INTEGER PRIMARY KEY AUTOINCREMENT,nom VARCHAR(255),prenom VARCHAR(255),sexe CHAR(1),id_etab INTEGER,motifs STRING(16) NOT NULL)");
            query.exec();
        }

        query.prepare("SELECT * FROM sqlite_master WHERE type = 'table' AND name = 'Evenement'");
        query.exec();
        query.next();
        if(query.value(0).toInt() == 0){
            query.clear();
            query.prepare("DROP TABLE Evenement");
            query.exec();

            query.clear();
            query.prepare("CREATE TABLE Evenement (id INTEGER PRIMARY KEY AUTOINCREMENT,id_eleve INTEGER  REFERENCES Eleve (id),date DATETIME,origine INTEGER,id_interlocuteur INTEGER)");
            query.exec();
       }



        QString message = "Prêt (connecté à : " + connection.databaseName() + ")";
        statusBar->showMessage(message);

    }else{
        QString message = "Erreur de connexion à la BDD : " + connection.lastError().text();
        statusBar->showMessage(message);
    }

}
