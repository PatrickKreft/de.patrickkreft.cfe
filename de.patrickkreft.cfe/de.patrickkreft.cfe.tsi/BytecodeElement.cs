namespace de.patrickkreft.cfe.tsi;

[Serializable]
public class BytecodeElement(
    BytecodeTag start,
    BytecodeTag end,
    BytecodeData? data,
    List<BytecodeElement>? sub
)
{
    public BytecodeTag Start { get; set; } = start;
    public BytecodeData? Data { get; set; } = data;
    public List<BytecodeElement>? Sub { get; set; } = sub;
    public BytecodeTag End { get; set; } = end;
}
