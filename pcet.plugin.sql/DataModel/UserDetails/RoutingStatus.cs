﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pcet.plugin.sql.DataModel.UserDetails
{
    public class RoutingStatus
    {
        [Key]
        [Column(Order = 1)]
        [StringLength(128)]
        public string userId { get; set; }
        [Key]
        [Column(Order = 2, TypeName = "datetime2")]
        public DateTime startTime { get; set; }
        [Column(Order = 3, TypeName = "datetime2")]
        public DateTime endTime { get; set; }
        [Key]
        [Column(Order = 4)]
        [StringLength(128)]
        public string routingStatus { get; set; }
    }
}
