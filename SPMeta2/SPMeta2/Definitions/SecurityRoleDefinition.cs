﻿using System.Collections.ObjectModel;

namespace SPMeta2.Definitions
{
    /// <summary>
    /// Allows to define and deploy SharePoint security role.
    /// </summary>
    public class SecurityRoleDefinition : DefinitionBase
    {
        #region contructors

        public SecurityRoleDefinition()
        {
            BasePermissions = new Collection<string>();
        }

        #endregion

        #region properties

        /// <summary>
        /// Name of the target security role.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the target security role.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Permissions of the target security role.
        /// </summary>
        public Collection<string> BasePermissions { get; set; }

        #endregion

        #region methods

        public override string ToString()
        {
            return string.Format("Name:[{0}] Description:[{1}]", Name, Description);
        }

        #endregion
    }
}