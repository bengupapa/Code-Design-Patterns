using DesignPatterns.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class MatterBuilderDirector
    {
        private IMatterBuilder _matterBuilder;

        public MatterBuilderDirector(IMatterBuilder builder)
        {
            _matterBuilder = builder;
        }

        public IMatter ConstructMatter()
        {
            _matterBuilder.BuildMortgagors("Papa Bengu", "Dikeledi Ngqwemla");
            _matterBuilder.BuildParties("Bond Attorney: Mike", "Mortgage Bank: FNB");
            _matterBuilder.BuildProperties("Flat");
            _matterBuilder.BuildFinaincials(new[]
            {
                new KeyValuePair<string, decimal>("Bond Loan", 45000),
                new KeyValuePair<string, decimal>("Bond Monthly Repayments", 45000),
                new KeyValuePair<string, decimal>("Bond Interest", Convert.ToDecimal(0.2))
            });

            return _matterBuilder.GetBond();
        }
    }
}
