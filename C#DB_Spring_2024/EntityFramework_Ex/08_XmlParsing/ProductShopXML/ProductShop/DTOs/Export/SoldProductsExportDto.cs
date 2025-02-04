﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProductShop.DTOs.Export
{
    [XmlType("SoldProduct")]
    public class SoldProductsExportDto
    {
        [XmlElement("count")]
        public int Count { get; set; }
        [XmlArray("products")]
        public ProductsForUsersExportDto[] Products { get; set; }
    }
}
