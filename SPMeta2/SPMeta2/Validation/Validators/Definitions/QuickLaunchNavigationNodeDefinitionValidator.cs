﻿using System.Collections.Generic;
using SPMeta2.Definitions;
using SPMeta2.Validation.Common;
using SPMeta2.Validation.Extensions;

namespace SPMeta2.Validation.Validators.Definitions
{
    public class QuickLaunchNavigationNodeDefinitionValidator : DefinitionBaseValidator
    {
        public override void Validate(DefinitionBase definition, List<ValidationResult> result)
        {
            Validate<QuickLaunchNavigationNodeDefinition>(definition, model =>
            {
                model
                    .NotEmptyString(m => m.Title, result)
                    .NoSpacesBeforeOrAfter(m => m.Title, result)

                    .NotEmptyString(m => m.Url, result)
                    .NoSpacesBeforeOrAfter(m => m.Url, result);

                if (!model.IsExternal)
                {
                    model
                        .NoSlashesBefore(m => m.Url, result);
                }
            });
        }
    }
}
