#include "evenementview.h"
#include "ui_evenementview.h"

EvenementView::EvenementView(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::EvenementView)
{
    ui->setupUi(this);
}

EvenementView::~EvenementView()
{
    delete ui;
}
