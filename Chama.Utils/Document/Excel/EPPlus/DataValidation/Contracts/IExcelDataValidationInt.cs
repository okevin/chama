using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chama.Utils.EPPlus.DataValidation.Formulas.Contracts;

namespace Chama.Utils.EPPlus.DataValidation.Contracts
{
    public interface IExcelDataValidationInt : IExcelDataValidationWithFormula2<IExcelDataValidationFormulaInt>, IExcelDataValidationWithOperator
    {
    }
}
