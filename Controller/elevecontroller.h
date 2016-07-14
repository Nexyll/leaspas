#ifndef ELEVECONTROLLER_H
#define ELEVECONTROLLER_H

#include <QWidget>
#include "Model/model.h"

class EleveController
{
public:
    EleveController(Model* _model);
    void addEleve(QString nom, QString prenom);

private:
    Model* model;
};

#endif // ELEVECONTROLLER_H
