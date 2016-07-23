DOCUMENT DE TRAVAIL / Tables statiques
=================================
Le présent fichier liste de façon linéaire l'ensemble des valeurs (= champ "type" ou "nom") que contient chacune des tables statiques (autres que *ELEVE*, *EVENEMENT* et *ETABLISSEMENT*).
Dans la mesure du possible, il serait souhaitable de **conserver l'ordre** (certes arbitraire) dans lequel sont listées ces valeurs pour la création des tables, afin que des portages logiciels ignorant ces tables statiques puissent fonctionner.

## 1. Tables dont les valeurs sont associées à chaque élève

### ORIGINE
Indique le tiers qui est à l'origine de la prise de contact de l'élève avec l'assistante sociale

	élèves
	familles
	équipes éducatives
	services extérieurs

### MOTIF
Motifs pour lesquels l'élève s'est présenté, au minimum 1, au maximum tous (16). Les motifs sont toujours rattachés à l'élève et non aux évènements ; ainsi l'ajout d'un nouvel évènement est susceptible de rajouter un nouveau motif.

	scolarité
	absentéisme et décrochage
	comportements
	conduites à risques
	difficultés familliales / soutien parentalité
	difficultés sociales, économiques
	accès aux droits
	violences intrafamiliales
	violences subies cadre scolaire
	violences agies, délinquance
	santé et bien-être
	sexualité
	handicap
	discrimination
	passage majorité

### NIVEAU
Pour information. Le niveau n'est pas traité lorsque les statistiques sont générées. La liste de valeurs est ici arbitraire (amenée à être statique, on pourrait ainsi rajouter les classes de primaire)

	6
	5
	4
	3
	2
	1
	T
	CAP1
	CAP2
	STS1
	STS2
	3PPRO

## 2. Tables dont les valeurs sont associées à chaque évènement

### CATEGORIE
Table des catégories d'évènements. Un évènement a forcément une seule et unique catégorie, nécéssairement une catégorie enfant, sauf si la catégorie parente n'a pas d'enfant (cas de "visite à domicile").

	Entretiens
		élèves
		parents/représentants légaux
		familles avec élève
	Visites à domicile
	Liaisonsorientationsconseils
		administration
		vie scolaire
		enseignants
		médecin
		infirmière
		COP- MGI
		services sociaux et éducatifs
		programme de réussite éducative
		autres partenaires
	Examens en commission
		interne à l'éducation nationale 
		externe à l'éducation nationale
	Rapports d'évaluation sociale
		absentéisme 
		orientation 
		protection enfance
		aides financières
		contrats jeunes majeurs
		accès aux droits
		autres
