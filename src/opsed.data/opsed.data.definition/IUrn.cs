namespace opsed.data.definition
{
    public interface IUrn
    {
        string Scheme { get; set; }
        string[] NamespaceSegments { get; set; }
        string Value { get; set; }
        string ToString();
    }
}