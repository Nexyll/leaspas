#ifndef ELEVEVIEW_H
#define ELEVEVIEW_H

#include <QWidget>

namespace Ui {
class EleveView;
}

class EleveView : public QWidget
{
    Q_OBJECT

public:
    explicit EleveView(QWidget *parent = 0);
    ~EleveView();

private:
    Ui::EleveView *ui;
};

#endif // ELEVEVIEW_H
