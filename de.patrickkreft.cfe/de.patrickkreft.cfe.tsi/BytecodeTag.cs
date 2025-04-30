namespace de.patrickkreft.cfe.tsi;

[Serializable]
public enum BytecodeTag
{
    None = 0,
    
    // Structure Elements
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
    PropertyEnd,
    
    // Primary Expression 
    TypeStart,
    TypeEnd,
    ValueStart,
    ValueEnd,
    
}
