﻿using Microsoft.SharePoint.Administration.Claims;
using SPMeta2.Containers.Assertion;
using SPMeta2.Definitions;
using SPMeta2.Definitions.Base;
using SPMeta2.SSOM.ModelHandlers;
using SPMeta2.Utils;

namespace SPMeta2.Regression.SSOM.Validation
{
    public class TrustedAccessProviderDefinitionValidator : TrustedAccessProviderModelHandler
    {
        #region methods

        public override void DeployModel(object modelHost, DefinitionBase model)
        {
            var definition = model.WithAssertAndCast<TrustedAccessProviderDefinition>("model", value => value.RequireNotNull());

            SPTrustedAccessProvider spObject = GetCurrentTrustedAccessProvider(modelHost, definition);

            var assert = ServiceFactory.AssertService
                                     .NewAssert(definition, spObject)
                                           .ShouldNotBeNull(spObject);

        }

        #endregion
    }
}