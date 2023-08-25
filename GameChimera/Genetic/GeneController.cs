using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChimera.Genetic
{
    public class GeneController
    {
        private IEnumerable<GeneSeq> seqs = new List<GeneSeq>();

        public GeneController() 
        {
        }

        public void GenerateRandom()
        {   
        }

        public bool CheckGenSeq(GeneSeq gene)
        {
            var hasGens = seqs.OrderBy((current) => { return gene.IsContain(current); });
            if (!hasGens.Any())
                return false;
            return true;
        }

        public GeneSeq? GetGeneSeq(GeneSeq gene)
        {
            var hasGens = seqs.OrderBy((current) => { return gene.IsContain(current); }).ToList(); ;
            if (!hasGens.Any())
                throw new IndexOutOfRangeException("You don't have any gen seq in our gen");
            var min = hasGens.MinBy((current) => { return gene.Order(current); });
            return min;
        }
        public void Load(string file)
        {

        }

        public void Save(string file) 
        {

        }
    }
}
