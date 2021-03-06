// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for IncidentsOperations.
    /// </summary>
    public static partial class IncidentsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of incidents associated to an alert rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            public static System.Collections.Generic.IEnumerable<Incident> ListByAlertRule(this IIncidentsOperations operations, string resourceGroupName, string ruleName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IIncidentsOperations)s).ListByAlertRuleAsync(resourceGroupName, ruleName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of incidents associated to an alert rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<Incident>> ListByAlertRuleAsync(this IIncidentsOperations operations, string resourceGroupName, string ruleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByAlertRuleWithHttpMessagesAsync(resourceGroupName, ruleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
