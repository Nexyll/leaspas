#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>

#include <Model/model.h>


namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();

    Model *getModel() const;
    void setModel(Model *value);

private slots:
    void on_pb_accueil_ajout_eleve_pressed();

    void on_pb_accueil_ajout_evt_pressed();

    void on_actionQuitter_triggered();

private:
    Ui::MainWindow *ui;
    Model* model;
};

#endif // MAINWINDOW_H
