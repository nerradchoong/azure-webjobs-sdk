﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

#if PUBLICPROTOCOL
namespace Microsoft.Azure.WebJobs.Protocols
#else
namespace Microsoft.Azure.WebJobs.Host.Protocols
#endif
{
    /// <summary>Represents a request to abort the host instance.</summary>
    [JsonTypeName("Abort")]
#if PUBLICPROTOCOL
    public class AbortHostInstanceMessage : HostMessage
#else
    internal class AbortHostInstanceMessage : HostMessage
#endif
    {
    }
}
