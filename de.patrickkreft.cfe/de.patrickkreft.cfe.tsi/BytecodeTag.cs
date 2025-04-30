namespace de.patrickkreft.cfe.tsi;

public enum BytecodeTag
{
    None = 0,
    FileStart,
    FileEnd,
    NamespaceStart,
    NamespaceEnd,
    ModuleStart,
    ModuleEnd,
    ImportStart,
    ImportEnd,
    ClassStart,
    ClassEnd,
    MethodStart,
    MethodEnd,
    PropertyStart,
    PropertyEnd
}