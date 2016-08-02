#ifndef MODEL_H
#define MODEL_H

#include <QtSql>
#include <qstatusbar.h>

class Model
{
public:
    Model(QStatusBar* stb);
    void addEleve(QString nom, QString prenom) const;

private:
    QSqlDatabase connection;
    void initDb();
    QStatusBar* statusBar;
    void verifyStruct() const;
    QString message;
};

#endif // MODEL_H
