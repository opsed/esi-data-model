using System;
using System.Collections.Generic;

namespace opsed.data.definition
{
    public interface IDocument
    {
        string Name { get; set; }
        DateTime Updated { get; set; }
        IUrn Urn { get; set; }
        Uri Uri { get; set; }
        IEnumerable<IProperty> Properties { get; set; }
        IEnumerable<IResource> Resources { get; set; }
    }
}