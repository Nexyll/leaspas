#include "elevecontroller.h"

EleveController::EleveController(Model *_model)
{
    model = _model;
}

void EleveController::addEleve(QString nom, QString prenom)
{
    model->addEleve(nom, prenom);
}
