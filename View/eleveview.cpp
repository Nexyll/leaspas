#include "eleveview.h"
#include "ui_eleveview.h"

EleveView::EleveView(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::EleveView)
{
    ui->setupUi(this);
}

EleveView::~EleveView()
{
    delete ui;
}
