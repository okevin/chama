﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chama.Utils.EPPlus.DataValidation.Formulas.Contracts;

namespace Chama.Utils.EPPlus.DataValidation.Contracts
{
    /// <summary>
    /// Data validation interface for decimal values
    /// </summary>
    public interface IExcelDataValidationDecimal : IExcelDataValidationWithFormula2<IExcelDataValidationFormulaDecimal>, IExcelDataValidationWithOperator
    {
    }
}
