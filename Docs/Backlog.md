# 226 - CRM - Backlog

* Auteur : Nicolas Glassey
* Projet : CRM
* Module : 226a

---

## Contexte
Votre client vous confie le développement d'un outil simple de gestion de contacts non-commerciale. Il s'agit d'un ONG voulant mieux organiser ces campagnes d'informations et de préventions.

### Rôle

Cet outil de CRM, en tout cas dans une première version, ne va pas gérer la notion de rôle, ni de session ni d'authentification. Seule l'aspect métier est demandé.

### Fonctionnalités

---
* Ajouter un contact :
    * Les propriétés sont :
        * Nom : "Riccard"
        * Prénom : "Mathieu"
        * Date de naissance : "15-FEB-1946"
        * Nationalité : France
        * Email : "mathieu.riccard@monk.org"

---
* Créer des listes d'envoi : 
    * Afin de pouvoir faire des publipostages et autres campagnes d'information, on veut pouvoir gérer des listes d'emails.
    * On doit être capable de créer de nouvelles listes
        * Une liste est définie par un nom (unique)
        * Une date de création (JJ/MMM/YYYY)
        * Une date de dernière mise à jour (JJ/MMM/YYYY)
        * Une liste d'adresse email ([RFC](http://www.faqs.org/rfcs/rfc822.html))
        * Il est possible de créer une liste sans adresse email

---
* Mettre à jour des listes :
    * On doit pouvoir ajouter à une liste existante : 
        * soit une adresse unique 
        * soit une liste d'adresses.
    * On doit pouvoir supprimer des éléments d'une liste existante :
        * soit une adresse
        * soit une liste d'adresses.
    * Il n'est pas possible d'ajouter deux fois la même adresse dans une liste donnée.

---
* Extraire les listes sur un fichier de type .csv.