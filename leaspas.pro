#-------------------------------------------------
#
# Project created by QtCreator 2016-07-11T22:51:39
#
#-------------------------------------------------

QT       += core gui sql

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = leaspas
TEMPLATE = app


SOURCES += main.cpp\
        mainwindow.cpp \
    View/eleveview.cpp \
    Controller/elevecontroller.cpp \
    Model/model.cpp

HEADERS  += mainwindow.h \
    View/eleveview.h \
    Controller/elevecontroller.h \
    Model/model.h

FORMS    += mainwindow.ui \
    View/eleveview.ui

RESOURCES +=
