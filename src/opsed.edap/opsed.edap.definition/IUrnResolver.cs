using System;
using System.Collections.Generic;
using opsed.data.definition;

namespace opsed.edap.definition
{
    public interface IUrnResolver
    {
        IEnumerable<IUrn> N2NN(IUrn resource);
        IEnumerable<Uri> N2LL(IUrn resource);
    }
}