using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Data.PecMemberModels
{
    public class GaroSelectidValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool selectOption = true;
            var selectedValue = Convert.ToInt32(value);
            if (selectedValue == 0)
            {
                selectOption = false;
            }
            return selectOption;
        }
    }
}
