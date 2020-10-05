using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims
{
    public class ClaimRepository
    {
        protected readonly Queue<Claim> _claimsDirectory = new Queue<Claim>();

        //CREATE
        public bool AddClaimToDirectory(Claim claim)
        {
            int startingCount = _claimsDirectory.Count;
            _claimsDirectory.Enqueue(claim);
            bool wasAdded = (_claimsDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //READALL
        public Queue<Claim> GetClaims()
        {
            return _claimsDirectory;
        }

        //READONE
       public Claim GetNextClaim()
        {
           foreach (Claim singleClaim in _claimsDirectory)
            {
                Console.WriteLine("Peek at next claim: {0}",
            _claimsDirectory.Peek());
            }
            return null;
        }
    }
}
