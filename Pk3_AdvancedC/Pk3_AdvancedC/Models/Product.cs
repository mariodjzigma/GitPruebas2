﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pk3_AdvacedCsharp.Models
{
    public class Product
    {
        // private string name;
        // public string Name {
        //   get { return name; }

        //set { name = value; }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Category { get; set; }
    }
}
