namespace de.patrickkreft.cfe.tsi;

public class BytecodeElement(
    BytecodeTag start,
    BytecodeTag end,
    BytecodeData data,
    List<BytecodeElement> superior,
    List<BytecodeElement> inferior
)
{
    public static BytecodeElement NoParent = new BytecodeElement(
        BytecodeTag.None, BytecodeTag.None, BytecodeData.NoData,
        new List<BytecodeElement>(), new List<BytecodeElement>()
    );

    public BytecodeTag Start { get; set; } = start;
    public BytecodeTag End { get; set; } = end;
    public BytecodeData Data { get; set; } = data;
    public List<BytecodeElement> Superior { get; set; } = superior;
    public List<BytecodeElement> Inferior { get; set; } = inferior;
}