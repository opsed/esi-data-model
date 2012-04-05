using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace opsed.data.definition
{
    public interface IESI
    {
        IEnumerable<ICase> Cases { get; set; }
    }
}