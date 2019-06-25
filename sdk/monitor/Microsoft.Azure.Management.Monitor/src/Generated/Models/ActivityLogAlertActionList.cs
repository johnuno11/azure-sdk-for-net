// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A list of activity log alert actions.
    /// </summary>
    public partial class ActivityLogAlertActionList
    {
        /// <summary>
        /// Initializes a new instance of the ActivityLogAlertActionList class.
        /// </summary>
        public ActivityLogAlertActionList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActivityLogAlertActionList class.
        /// </summary>
        /// <param name="actionGroups">The list of activity log alerts.</param>
        public ActivityLogAlertActionList(IList<ActivityLogAlertActionGroup> actionGroups = default(IList<ActivityLogAlertActionGroup>))
        {
            ActionGroups = actionGroups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of activity log alerts.
        /// </summary>
        [JsonProperty(PropertyName = "actionGroups")]
        public IList<ActivityLogAlertActionGroup> ActionGroups { get; set; }

    }
}