using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims
{
    public class Claim
    {
        public enum ClaimType { Home, Car, Theft}
      
        public string Description { get; set; }
        public bool IsValid { get; set; }
        public DateTime DateOfClaim { get; set; }
        public DateTime DateOfIncident { get; set; }
        public int ClaimID { get; set; }
        public double ClaimAmount { get; set; }
        public ClaimType TypeOfClaim { get; set; }

        public Claim() { }

        public Claim (int claimId, ClaimType cType, string claimDescription, DateTime doi, DateTime doc, double claimAmount, bool isValid)
        {
            claimId = ClaimID;
            TypeOfClaim = cType;
            Description = claimDescription;
            DateOfClaim = doc;
            DateOfIncident = doi;
            ClaimAmount = claimAmount;
            IsValid = isValid;

        }
    }
}
