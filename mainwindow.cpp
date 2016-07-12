#include "mainwindow.h"
#include "ui_mainwindow.h"

#include <qmessagebox.h>

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    ui->statusBar->showMessage("Prêt");
    model = new Model(ui->statusBar);

}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::on_pb_accueil_ajout_eleve_pressed()
{
    ui->tabWidget->setCurrentIndex(1);
}

void MainWindow::on_pb_accueil_ajout_evt_pressed()
{
    ui->tabWidget->setCurrentIndex(2);
}


