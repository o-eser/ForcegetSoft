using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcegetSoft.Core.Enums
{
    public enum Currency
    {
        [Display(Name = "USD - US Dollar")]
        USD=1,
        [Display(Name = "CNY - Chinese Yuan")]
        CNY,
        [Display(Name = "TRY - Turkish Lira")]
        TRY
    }
}
