using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Interfaces
{
    public interface IMatter
    {
        List<string> Morgagors { get; set; }
        List<string> Properties { get; set; }
        List<string> Parties { get; set; }
        Dictionary<string, decimal> Financials { get; set; }
    }

    public interface IMatterBuilder
    {
        void BuildMortgagors(params string[] mortgagors);
        void BuildProperties(params string[] properties);
        void BuildParties(params string[] parties);
        void BuildFinaincials(params KeyValuePair<string, decimal>[] financials);
        IMatter GetBond();
    }
}
