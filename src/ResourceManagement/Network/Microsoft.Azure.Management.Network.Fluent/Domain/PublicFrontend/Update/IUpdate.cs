// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent.PublicFrontend.Update
{

    using Microsoft.Azure.Management.Network.Fluent.HasPublicIpAddress.Update;
    using Microsoft.Azure.Management.Resource.Fluent.Core.ChildResourceActions;
    using Microsoft.Azure.Management.Network.Fluent.LoadBalancer.Update;
    /// <summary>
    /// The stage of a public frontend update allowing to specify an existing public IP address.
    /// </summary>
    public interface IWithPublicIpAddress  :
        IWithExistingPublicIpAddress<Microsoft.Azure.Management.Network.Fluent.PublicFrontend.Update.IUpdate>
    {
    }
    /// <summary>
    /// The entirety of a public frontend update as part of an Internet-facing load balancer update.
    /// </summary>
    public interface IUpdate  :
        ISettable<Microsoft.Azure.Management.Network.Fluent.LoadBalancer.Update.IUpdate>,
        IWithPublicIpAddress
    {
    }
}