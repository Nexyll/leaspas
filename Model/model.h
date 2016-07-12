#ifndef MODEL_H
#define MODEL_H

#include <QtSql>
#include <qstatusbar.h>

class Model
{
public:
    Model(QStatusBar* stb);

private:
    QSqlDatabase connection;
    void initDb();
    QStatusBar* statusBar;
    void verifyStruct();
};

#endif // MODEL_H
