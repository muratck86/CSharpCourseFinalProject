using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                    return logic;
            }
            return null;
        }

        //Alternative
        /*
        public static List<IResult> Run(params IResult[] logics)
        {
            var listOfErrors = new List<IResult>();
            foreach (var logic in logics)
            {
                if (!logic.Success)
                    listOfErrors.Add(logic);
            }
            return listOfErrors;
        }

        */
    }
}
