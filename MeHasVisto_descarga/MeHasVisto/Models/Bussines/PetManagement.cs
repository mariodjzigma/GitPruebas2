using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace MeHasVisto.Models.Bussines
{
    public class PetManagement
    {
        public static void CreateThumbNail(
            string fileName, string filePath,
            int thunbWi, int thumbHi,
            bool maintainAspect)
    {
     var originalFile = Path.Combine(filePath,fileName);
        var source = Image.FromFile(originalFile);
        if(source.Width <= thumbHi &&
        source.Height <=thumbHi)
        return;

             Bitmap thumbnail;
        try
    {
       int wi = thumbWi;
       int hi = thumbHi;
        if (maintainAspect)
    {
       //mantener el aspecto a pesar 
        //de los parametros de tamaño
        //de la vista previa
        wi = thumbWi;
        hi = (int)(source.height *
            ((decimal)thumbWi / source.Width));

    }

    }

            else
            {
              hi = thumbHi;
              wi = (int)(source.Width *
                  ((decimal)thumbHi / source.Height));
              
            }
            thumbnail = new Bitmap(wi, hi);
            using(Graphics g = Graphics.FromImage(thumbnail))
            {
               g.InterpolationMode = 
                InterpolationMode.HighQualityBicubic;
                g.FillRectangle(Brushes.Transparent),
                0, 0,
                wi, hi);
                decimal.DrawImage(source, 0, 0, wi, hi);
            }

            var thumbnailName =  Path.Combine(filePath,
                "thumbnail_" + fileName);
            thumbnail.Save(thumbnailName);
            {

        catch
    {
            {
    }

            {

       
}
        }