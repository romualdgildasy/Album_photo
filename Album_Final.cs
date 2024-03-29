using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album
{
    class Albumphoto_final
    {
        public static void Main(String[] args)
        {
            AlbumPhoto album = new AlbumPhoto();
            //ajout de quelque photos
            album.AjouterPhoto("photo1.jpg");
            album.AjouterPhoto("photo2.jpg");
            album.AjouterPhoto("photo3.jpg");
            album.AjouterPhoto("photo4.jpg");

            // choix de la photo de couverture
            album.ChoisirPhotoDeCouverture("photo2.jpg");

            // suppression de la photo
            album.SupprimerPhoto("photo2.jpg");
        }
    }
}
