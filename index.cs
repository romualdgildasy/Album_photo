using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album
{

    public class Photo
    {
        public string Url { get; set; }

        public Photo(string url)
        {
            Url = url;
        }
    }

    class AlbumPhoto
    {
        private List<string> photos = new List<string>();
        private string photoDeCouverture;

        public void AjouterPhoto(string url)
        {
            photos.Add(uri);
            if (photoDeCouverture == null)
            {
                photoDeCouverture = url;
            }
        }

        public void SupprimerPhoto(string url)
        {
            photos.Remove(uri);
            if (photoDeCouverture == uri)
            {
                photoDeCouverture = photos.Count > 0 ? photos[0] : null;
            }
        }

        public void ChoisirPhotoDeCouverture(string url)
        {
            if (photos.Contains(url))
            {
                photoDeCouverture = url;
            }
            else
            {
                Console.WriteLine("La photo spécifiée n'est pas dans l'album.");
            }
        }
    }
}