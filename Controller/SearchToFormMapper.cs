using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using toolsuiteapp.View;

namespace toolsuiteapp.Controller
{

    public class SearchToFormMapper
    {
        private Dictionary<string, Type> searchTermToFormMap;


        public SearchToFormMapper()
        {
            searchTermToFormMap = new Dictionary<string, Type>
            {
                {"wealth management", typeof(WealthMAnagementForm) },
               { "Data Management", typeof(DataManagementForm)},
                {"Asset Management", typeof(DataManagementForm)},
                { "Investment Management", typeof(InvestmentBankingForm)},
            };
        }

        public Type GetFormTypeForSearchTerm(string searchTerm)
        {
            if (searchTermToFormMap.TryGetValue(searchTerm.ToLower(), out Type formType))
            {
                return formType;
            }

            return null;
        }
    }
}
