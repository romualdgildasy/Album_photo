# Album_photo

quand j'ai fais connaissance de l'énoncé  j'ai reflechis comme suit: 
j'a créé deux classes : Photo et Album.
La classe Photo contient les propriétés suivantes :
Id: Identifiant unique de la photo.
Url: L’URL de l’image.
AlbumId: L’identifiant de l’album auquel appartient la photo.
PhotoDeCouverture: Un indicateur pour savoir si la photo est la photo de couverture de l’album.

La classe Album contient les propriétés suivantes :
Id: Identifiant unique de l’album.
Nom: Le nom de l’album.
IdPhotoDeCouverture: L’identifiant de la photo de couverture de l’album.
Photos: Une liste de photos appartenant à l’album.

Gestion des albums:
La classe GestionnaireAlbums gère les opérations sur les albums :
CreerAlbum: Crée un nouvel album avec un nom donné.
AjouterPhotoAAlbum: Ajoute une nouvelle photo à un album existant.
SupprimerPhotoDeAlbum: Supprime une photo d’un album.
DefinirPhotoDeCouverture: Définit la photo de couverture d’un album.
AfficherAlbum: Affiche les photos d’un album, y compris la photo de couverture.
Identifiants uniques:
Vous avez implémenté une méthode GenererIdentifiantUnique pour générer des identifiants uniques (par exemple, en utilisant Guid.NewGuid().GetHashCode()).
Exemple d’utilisation:
Dans la méthode Main, j'ai créé un gestionnaire d’albums, ajouté deux photos à l’album “Photos de vacances”, défini la deuxième photo comme photo de couverture, puis affiché l’album.
