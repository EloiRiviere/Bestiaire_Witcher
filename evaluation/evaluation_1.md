# Evaluation

## Remarques générales

* Je ne pourrais évaluer qu'Eloi à moins que Baptiste ne me prouve son implication sur le projet. 

## Objets 2 : Conception et programmation orientées objets (C#, .NET)

### Documentation

| Critère | Points | Max | Commentaires |
|---------|--------|-----|-|
| Je sais concevoir un diagramme de classes qui représente mon application. | 6 | 8 | Il manque une description de votre diagramme 
| Je sais réaliser un diagramme de paquetages qui illustre bien l'isolation entre les parties de mon application. | 2 | 4 | Il manque les relations entre les paquetages
| Je sais réaliser un diagramme de séquences qui décrit l'un des processus de mon application. | 0 | 2 | Pas de diagramme
| Je sais décrire mes trois diagrammes en mettant en valeur et en justifiant les éléments essentiels. | 0 | 6 | Pas de description.

**Note provisoire**: 08/20

### Code

| Critère | Points | Max | Commentaires |
|---------|--------|-----|-|
| Je maîtrise les bases de la programmation C# (classes, structures, instances...) | 2 | 2 | Peut-être pourriez-vous étoffer un peu votre modèle et ajouter quelques classes ? | 
| Je sais utiliser l'abstraction à bon escient (héritage, interface, polymorphisme). | 0 | 3 | Ces concepts sont absents de votre projet. Il faut étoffer votre métier pour ajouter des classes / interfaces (telles qu'elles sont décrites dans votre diagramme de classe) |
| Je sais gérer des collections simples (tableaux, listes, ...) | 2 | 2 | OK |
| Je sais gérer des collections avancées (dictionnaires). | 0 | 2 | Vous n'avez pas utilisé de collection avancée pour l'instant |
| Je sais contrôler l'encapsulation au sein de mon application. | 2.5 | 5 | Beaucoup de choses publiques, il faut encore travailler votre diagramme de classes (métier) |
| Je sais tester mon application. | 3 | 4 | Il y a des tests, c'est bien. Pensez à utiliser les assertions plutôt que le Debug.Write |
| Je sais utiliser LINQ. | 1 | 1 | OK |
| Je sais gérer les évènements. | 0 | 1 | Pour l'instant, vous n'utilisez pas d'évènement côté métier. |

**Note provisoire**: 10.5/20

## IHM : Interface Homme-Machine (WAML, WPF)

### Documentation

| Critère | Points | Max | Commentaires |
|---------|--------|-----| ------------ |
| Je sais décrire le contexte de mon application pour qu'il soit compréhensible par tout le monde. | 0 | 4 | Pas de description
| Je sais dessiner des sketchs pour concevoir les fenêtres de mon application. | 4 | 4 | OK
| Je sais enchaîner mes sketchs au sein d'un storyboard. | 4 | 4 | OK
| Je sais concevoir un diagramme de cas d'utilisation qui représente les fonctionnalités de mon application. | 0 | 5 | Pas de diagramme 
| Je sais concevoir une application ergonomique. | 2 | 2 | L'application est agréable et plutôt bien construite.
| Je sais concevoir une application avec une prise en compte de l'accessibilité. | 1 | 1 | En quoi votre application est-elle accessible ? => dans la description !

**Note provisoire**: 11/20

### Code

| Critère | Points | Max | Commentaires |
|---------|--------|-----|--------------|
| Je sais choisir mes layouts à bon escient. | 1 | 1 | OK |
| Je sais choisir mes composants à bon escient. | 1 | 1 | OK |
| Je sais créer mon propre composant. | 1.5 | 2 | Il faut maintenant les utiliser ! |
| Je sais personnaliser mon application en utilisant des ressources et des styles. | 2 | 2 | OK |
| Je sais utiliser les DataTemplates (locaux et globaux). | 2 | 2 | OK |
| Je sais intercepter les évènements de la vue. | 2 | 2 | Les click sur les boutons sont gérés. |
| Je sais notifier la vue depuis des évènements métier. | 0 | 2 | Le métier ne lance pas d'évènement |
| Je sais gérer le DataBinding sur mon master. | 1 | 1 | OK |
| Je sais gérer le DataBinding sur mon détail. | 0 | 1 | I n'y a pas de page de detail  |
| Je sais gérer le DataBinding et les Dependency Property sur mes UserControls. | 0 | 2 | il faut développer les UC maintenant |
| Je sais développer un Master/Detail (navigation, liens entre les deux écrans, ...) | 3 | 4 | La navigation est présente et bien faite. Il manque cependant la possibilité d'EDITER ou d'AJOUTER des éléments |

**Note provisoire**: 13.5/20

## Projet Tuteuré S2

### Documentation

| Critère | Points | Max | Commentaires |
|---------|--------|-----| ------------ |
| Je sais mettre en avant dans mon diagramme de classes la persistance de mon application. | 1 | 2 |  Il faut le mettre plus en avant (et modéliser les fenêtres par ex. pour que l'on puisse comprendre quand intervient la sauvegarde)
| Je sais mettre en avant dans mon diagramme de classes ma partie personnelle. | 0 | 4 | La partie personnelle n'est pas clairement mise en avant (existe-t-elle ?)
| Je sais mettre en avant dans mon diagramme de paquetages la persistance de mon application. | 0 | 4 | Pas assez de mise en avant
| Je sais réaliser une vidéo de 1 à 3 minutes qui montre la démo de mon application. | 0 | 10 | Pas de vidéo

**Note provisoire**: 1/20

### Code

| Critère | Points | Max | Commentaires |
|---------|--------|-----|--------------|
| Je sais coder la persitance au sein de mon application. | 3 | 3 | OK |
| Je sais coder une fonctionnalité qui m'est personnelle. | 0 | 3 | Quelle est votre fonctionnalité personnelle ? |
| Je sais documenter mon code. | 0 | 2 | La documentation manque dans votre code. |
| Je sais utiliser Git. | 2 | 2 | Très bonne utilisation de Git |
| Je sais développer une application qui compile. | 3 | 3 | L'application compile |
| Je sais développer une application fonctionnelle. | 4 | 4 | Je n'ai pas pu tout tester. |
| Je sais mettre à disposition un outil pour déployer mon application. | 0 | 3 | Pas d'installer |

**Note provisoire**: 10/20