﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims
{
    public class Claim
    {
        public string ClaimType { get; set; }
        public string Description { get; set; }
        public bool IsValid { get; set; }
        public DateTime DateOfClaim { get; set; }
        public DateTime DateOfIncident { get; set; }

    }
}
