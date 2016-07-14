#ifndef ELEVEVIEW_H
#define ELEVEVIEW_H

#include <QWidget>

#include <Controller/elevecontroller.h>

namespace Ui {
class EleveView;
}

class EleveView : public QWidget
{
    Q_OBJECT

public:
    explicit EleveView(QWidget *parent = 0);
    ~EleveView();
    void setModel(Model *value);

private slots:
    void on_pbAjoutEleve_pressed();

private:
    Ui::EleveView *ui;
    EleveController* controller;
    Model* model;
};

#endif // ELEVEVIEW_H
