using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Text;


namespace MeHasVisto.Models
{
    public class PictureModel
    {
        [Required]
        public HttpPostedFileBase Picturefile { get; set; }
    }
}