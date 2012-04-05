using System;

using opsed.data.definition;

namespace opsed.data.domain
{
    public class Urn : IUrn
    {
        public Urn(string value)
        {
            string[] segments = value.Split(':');
            if (segments.Length == 1)
            {
                Value = segments[0];
                return;
            }

            if (segments.Length > 0)
                Scheme = segments[0];

            if (segments.Length > 1)
                Value = segments[segments.Length - 1];

            if (segments.Length > 2)
            {
                NamespaceSegments = new string[segments.Length - 2];
                Array.Copy(segments, 1, NamespaceSegments, 0, NamespaceSegments.Length);
            }
        }

        public string Scheme { get; set; }

        public string[] NamespaceSegments { get; set; }

        public string Value { get; set; }

        public override string ToString()
        {
            int length = (null == NamespaceSegments ? 0 : NamespaceSegments.Length) + 2;

            string[] segments = new string[length];
            segments[0] = Scheme;
            segments[length - 1] = Value;
            if (null != NamespaceSegments)
            {
                for (int i = 1; i < NamespaceSegments.Length + 1; i++)
                    segments[i] = NamespaceSegments[i - 1];
            }
            return string.Join(":", segments);
        }

    }
}
