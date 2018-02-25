using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    enum Pictures
    {
        People,
        Borziy,
        Autumn,
        Flower
    }

    static class ImageDownloader
    {
        static public Bitmap DownloadImage(string url)
        {
            var client = new WebClient();
            using (MemoryStream stream = new MemoryStream(client.DownloadData(url)))
            {
                client.Dispose();
                return new Bitmap(stream);
            }
        }
    }

    class Flyweight
    {
        private Dictionary<Pictures, Bitmap> Images;

        public Flyweight()
        {
            Images = new Dictionary<Pictures, Bitmap>();

            Images.Add(Pictures.Autumn, ImageDownloader.DownloadImage("https://www.jssor.com/demos/img/gallery/980x380/002.jpg"));
            Images.Add(Pictures.People, ImageDownloader.DownloadImage("https://www.aussiespecialist.com/content/asp/en_gb/sales-resources/image-and-video-galleries/jcr:content/mainParsys/hero/image.adapt.1663.medium.jpg"));
            Images.Add(Pictures.Borziy, ImageDownloader.DownloadImage("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR4UPAZXWkA3cMiUZzS9aCBIsyJtsZSRThgYmTB1bCEt1SFWan5WA"));
            Images.Add(Pictures.Flower, ImageDownloader.DownloadImage("https://static.pexels.com/photos/658687/pexels-photo-658687.jpeg"));
        }

        public Bitmap GetImage(Pictures picture)
        {
            if (!Images.ContainsKey(picture))
                throw new ArgumentException("Image not found!");
            return Images[picture];
        }
    }
}
