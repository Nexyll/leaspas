#------------------------------------------------------------
#        Script SQLite  
#------------------------------------------------------------


#------------------------------------------------------------
# Table: ELEVE
#------------------------------------------------------------
CREATE TABLE ELEVE(
	ID                INTEGER PRIMARY KEY autoincrement NOT NULL ,
	nom               TEXT ,
	prenom            TEXT ,
	sexe              TEXT ,
	ID_ETABLISSEMENT  INTEGER NOT NULL ,
	ID_NIVEAU         INTEGER NOT NULL ,
	ID_ORIGINE        INTEGER NOT NULL ,
	
	FOREIGN KEY (ID_ETABLISSEMENT) REFERENCES ETABLISSEMENT(ID),
	FOREIGN KEY (ID_NIVEAU) REFERENCES NIVEAU(ID),
	FOREIGN KEY (ID_ORIGINE) REFERENCES ORIGINE(ID)
);


#------------------------------------------------------------
# Table: ETABLISSEMENT
#------------------------------------------------------------
CREATE TABLE ETABLISSEMENT(
	ID          INTEGER PRIMARY KEY autoincrement NOT NULL ,
	nom         TEXT ,
	type        TEXT ,
	population  INTEGER
);


#------------------------------------------------------------
# Table: NIVEAU
#------------------------------------------------------------
CREATE TABLE NIVEAU(
	ID   INTEGER PRIMARY KEY autoincrement NOT NULL ,
	nom  TEXT
);


#------------------------------------------------------------
# Table: EVENEMENT
#------------------------------------------------------------
CREATE TABLE EVENEMENT(
	ID            INTEGER PRIMARY KEY autoincrement NOT NULL ,
	date_evt      DATE ,
	ID_CATEGORIE  INTEGER NOT NULL ,
	ID_ELEVE      INTEGER NOT NULL ,
	
	FOREIGN KEY (ID_CATEGORIE) REFERENCES CATEGORIE(ID),
	FOREIGN KEY (ID_ELEVE) REFERENCES ELEVE(ID)
);


#------------------------------------------------------------
# Table: CATEGORIE
#------------------------------------------------------------
CREATE TABLE CATEGORIE(
	ID    INTEGER PRIMARY KEY autoincrement NOT NULL ,
	nom   TEXT ,
	parent  INTEGER NOT NULL ,
	
	FOREIGN KEY (parent) REFERENCES CATEGORIE(ID)
);


#------------------------------------------------------------
# Table: ORIGINE
#------------------------------------------------------------
CREATE TABLE ORIGINE(
	ID    INTEGER PRIMARY KEY autoincrement NOT NULL ,
	type  TEXT
);


#------------------------------------------------------------
# Table: MOTIF
#------------------------------------------------------------
CREATE TABLE MOTIF(
	ID   INTEGER PRIMARY KEY autoincrement NOT NULL ,
	nom  TEXT
);


#------------------------------------------------------------
# Table: RELATION_MOTIF_ELEVE
#------------------------------------------------------------
CREATE TABLE RELATION_MOTIF_ELEVE(
	ID        INTEGER NOT NULL ,
	ID_ELEVE  INTEGER NOT NULL ,
	PRIMARY KEY (ID,ID_ELEVE) ,
	
	FOREIGN KEY (ID) REFERENCES MOTIF(ID),
	FOREIGN KEY (ID_ELEVE) REFERENCES ELEVE(ID)
);