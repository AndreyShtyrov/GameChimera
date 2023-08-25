using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace GameChimera.Genetic
{
    public class GeneSeq
    {
        public List<GenToken> Gens
        { get; }

        int Size { get; }

        public GeneSeq(List<GenToken> gens)
        {
            Gens = gens;
            Size = gens.Count;
        }

        public bool IsContain(GeneSeq gen)
        {
            int i = 0;
            bool onlyOneShift = true;
            foreach (var token in gen.Gens)
            {
                if (token != Gens[i])
                    if (token == Gens[i + 1] && onlyOneShift)
                    {
                        i++;
                        onlyOneShift = false;
                    }
                    else
                        return false;
                i++;
            }
            return true;
        }

        public int Order(GeneSeq gen)
        {
            int i = 0;
            int order = 0;
            bool onlyOneShift = true;
            foreach (var token in gen.Gens)
            {
                if (token != Gens[i])
                    if (token == Gens[i + 1] && onlyOneShift)
                    {
                        order = i;
                        i++;
                        onlyOneShift=false;
                    }
                    else
                        return Gens.Count + 1;
                i++;
            }
            return order;
        }
        public Tuple<GeneSeq, GeneSeq> SplitGen()
        {
            if (Size > 2)
                throw new Exception("SplitGen can not applied to Gen, that is not consited four gens");
            var left = new GeneSeq(new List<GenToken>() { Gens[0], Gens[1] });
            var right = new GeneSeq(new List<GenToken>() { Gens[2], Gens[3] });
            return Tuple.Create(left, right);
        }
    }
}
