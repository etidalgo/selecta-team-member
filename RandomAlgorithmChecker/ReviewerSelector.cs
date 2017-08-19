using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RandomAlgorithmChecker
{
    class ReviewerSelector
    {
        public static string SelectReviewer(string commitHash, string author, IEnumerable<string> teamMembers)
        {
            var allTeamMembers = teamMembers.ToArray();
            var reviewerPool = allTeamMembers;
            if (!string.IsNullOrEmpty(author))
                reviewerPool = allTeamMembers.Except(new List<string> {author}).ToArray();
            var sum = BigInteger.Parse("0" + commitHash, NumberStyles.HexNumber);
            var selectedIdx = (int)(sum % reviewerPool.Length);
            return reviewerPool.ElementAt(selectedIdx);
        }

    }
}
