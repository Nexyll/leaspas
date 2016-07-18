#------------------------------------------------------------
#        Script SQLite  
#------------------------------------------------------------


#------------------------------------------------------------
# Table: ELEVE
#------------------------------------------------------------
CREATE TABLE ELEVE(
	ID                INTEGER autoincrement NOT NULL ,
	nom               TEXT ,
	prenom            TEXT ,
	sexe              TEXT ,
	ID_ETABLISSEMENT  INTEGER NOT NULL ,
	ID_NIVEAU         INTEGER NOT NULL ,
	ID_ORIGINE        INTEGER NOT NULL ,
	PRIMARY KEY (ID) ,
	
	FOREIGN KEY (ID_ETABLISSEMENT) REFERENCES ETABLISSEMENT(ID),
	FOREIGN KEY (ID_NIVEAU) REFERENCES NIVEAU(ID),
	FOREIGN KEY (ID_ORIGINE) REFERENCES ORIGINE(ID)
);


#------------------------------------------------------------
# Table: ETABLISSEMENT
#------------------------------------------------------------
CREATE TABLE ETABLISSEMENT(
	ID          INTEGER autoincrement NOT NULL ,
	nom         TEXT ,
	type        TEXT ,
	population  INTEGER ,
	PRIMARY KEY (ID)
);


#------------------------------------------------------------
# Table: NIVEAU
#------------------------------------------------------------
CREATE TABLE NIVEAU(
	ID   INTEGER autoincrement NOT NULL ,
	nom  TEXT ,
	PRIMARY KEY (ID)
);


#------------------------------------------------------------
# Table: EVENEMENT
#------------------------------------------------------------
CREATE TABLE EVENEMENT(
	ID            INTEGER autoincrement NOT NULL ,
	date_evt      NUMERIC ,
	ID_CATEGORIE  INTEGER NOT NULL ,
	ID_ELEVE      INTEGER NOT NULL ,
	PRIMARY KEY (ID) ,
	
	FOREIGN KEY (ID_CATEGORIE) REFERENCES CATEGORIE(ID),
	FOREIGN KEY (ID_ELEVE) REFERENCES ELEVE(ID)
);


#------------------------------------------------------------
# Table: CATEGORIE
#------------------------------------------------------------
CREATE TABLE CATEGORIE(
	ID    INTEGER autoincrement NOT NULL ,
	nom   TEXT ,
	parent  INTEGER NOT NULL ,
	PRIMARY KEY (ID) ,
	FOREIGN KEY (parent) REFERENCES CATEGORIE(ID)
);


#------------------------------------------------------------
# Table: ORIGINE
#------------------------------------------------------------
CREATE TABLE ORIGINE(
	ID    INTEGER autoincrement NOT NULL ,
	type  TEXT ,
	PRIMARY KEY (ID)
);


#------------------------------------------------------------
# Table: MOTIF
#------------------------------------------------------------
CREATE TABLE MOTIF(
	ID   INTEGER autoincrement NOT NULL ,
	nom  TEXT ,
	PRIMARY KEY (ID)
);


#------------------------------------------------------------
# Table: RELATION_MOTIF_ELEVE
#------------------------------------------------------------
CREATE TABLE RELATION_MOTIF_ELEVE(
	ID        INTEGER autoincrement NOT NULL ,
	ID_MOTIF  INTEGER NOT NULL ,
	ID_ELEVE  INTEGER NOT NULL ,
	PRIMARY KEY (ID_MOTIF,ID_ELEVE) ,
	
	FOREIGN KEY (ID_MOTIF) REFERENCES MOTIF(ID),
	FOREIGN KEY (ID_ELEVE) REFERENCES ELEVE(ID)
);