using System;
using System.Collections.Generic;

namespace opsed.data.definition
{
    public interface ICase
    {
        string Name { get; set; }
        DateTime Updated { get; set; }
        IUrn Urn { get; set; }
        Uri Uri { get; set; }

        IEnumerable<ICustodian> Custodians { get; set; }
    }
}