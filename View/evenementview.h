#ifndef EVENEMENTVIEW_H
#define EVENEMENTVIEW_H

#include <QWidget>

namespace Ui {
class EvenementView;
}

class EvenementView : public QWidget
{
    Q_OBJECT

public:
    explicit EvenementView(QWidget *parent = 0);
    ~EvenementView();

private:
    Ui::EvenementView *ui;
};

#endif // EVENEMENTVIEW_H
