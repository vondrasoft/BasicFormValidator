﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFormValidator.Collection
{
    class ValidatorMessageCollection : IValidatorMessageCollection
    {
        public Dictionary<ValidatorManager.Messages, string> getMessages()
        {
            return new Dictionary<ValidatorManager.Messages, string> 
            {
                { ValidatorManager.Messages.Required, "{component} - This field is required."  },
                { ValidatorManager.Messages.MinDate, "{component} - Date must be from {YYYY-MM-dd}" },
                { ValidatorManager.Messages.MaxDate, "{component} - Date must be to {YYYY-MM-dd}" },
                { ValidatorManager.Messages.MinLength, "{component} - The minimum length is {length}" }
            };
        }
    }
}