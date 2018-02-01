using DesignPatterns.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Models
{
    public abstract class BaseMatterBuilder
    {
        protected IMatter Matter { get; set; }
    }

    public class BondBuilder : BaseMatterBuilder, IMatterBuilder
    {
        public BondBuilder()
        {
            this.Matter = new Bond();
        }

        public void BuildFinaincials(params KeyValuePair<string, decimal>[] financials)
        {
            Array.ForEach(financials, fin => this.Matter.Financials.Add(fin.Key, fin.Value));
        }

        public void BuildMortgagors(params string[] mortgagors)
        {
            this.Matter.Morgagors.AddRange(mortgagors);
        }

        public void BuildParties(params string[] parties)
        {
            this.Matter.Parties.AddRange(parties);
        }

        public void BuildProperties(params string[] properties)
        {
            this.Matter.Properties.AddRange(properties);
        }

        public IMatter GetBond()
        {
            return this.Matter;
        }
    }

    public class Bond : IMatter
    {
        public List<string> Morgagors { get; set; }
        public List<string> Properties { get; set; }
        public List<string> Parties { get; set; }
        public Dictionary<string, decimal> Financials { get; set; }

        public Bond()
        {
            this.Morgagors = new List<string>();
            this.Properties = new List<string>();
            this.Parties = new List<string>();
            this.Financials = new Dictionary<string, decimal>();
        }
    }
}
