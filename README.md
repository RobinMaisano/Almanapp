# Almanapp

Mini appli console permettant d'afficher l'almanax du jour.  
POC en C# avec des tests NUnit.  

Les jours sont parfois faux, me basant sur un fichier JSON en ressource.  
Je ne sais pas exactement pourquoi mais Ankama change le type et le nombre de ressources a récupérer certains jours, d'une année sur l'autre.

Améliorations envisagées mais qui ne seront probablement pas mises en place faute de motivation :  
* Afficher un petit menu permettant de sélectionner :  
[ ] Afficher les 5 prochains jours,  
[ ] Entrer une date et afficher l'offrande du jour saisi,  
* Aller récupérer l'offrande sur internet plutot que via une ressource statique  
 (problème, l'HTML du site d'ankama ne contient pas d'id pour la balise contenant l'offrande. Parsage manuel obligatoire.)
* Mise en place du *DP Factory* et laisser a l'utilisateur le choix (via le menu) de la méthode de récupération des données : Local (Ressource) ou Online (krosmoz.com)  

Almanax : [https://www.krosmoz.com/fr/almanax]
