using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using opsed.data.definition;
using opsed.edap;
using opsed.edap.definition;

namespace opsed.edap.definition
{
    public interface IESIDataSource : IUrnResolver
    {
        IAtomFeed LIST(IUrn resource, string contentType);
        IESI GET(IUrn resource, string contentType);
        void POST(IESI esi);
        void DELETE(IUrn resource);
    }
}
