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

void EleveView::on_pbAjoutEleve_pressed()
{
    controller->addEleve(ui->leNom->text(), ui->lePrenom->text());
}

void EleveView::setModel(Model *value)
{
    model = value;
    controller = new EleveController(model);
}
