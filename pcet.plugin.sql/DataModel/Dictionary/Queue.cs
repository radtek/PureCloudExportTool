﻿using System.ComponentModel.DataAnnotations;

namespace pcet.plugin.sql.DataModel.Dictionary
{
    public class Queue : IDictionaryItem
    {
        [Key]
        public string id { get; set; }
        public string name { get; set; }
    }
}
