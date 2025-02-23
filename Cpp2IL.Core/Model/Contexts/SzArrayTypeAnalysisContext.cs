using Cpp2IL.Core.Utils;
using LibCpp2IL.BinaryStructures;

namespace Cpp2IL.Core.Model.Contexts;

public class SzArrayTypeAnalysisContext : WrappedTypeAnalysisContext
{
    public SzArrayTypeAnalysisContext(TypeAnalysisContext elementType, AssemblyAnalysisContext referencedFrom) : base(elementType, referencedFrom)
    {
    }

    public SzArrayTypeAnalysisContext(Il2CppType rawType, AssemblyAnalysisContext referencedFrom)
        : this(referencedFrom.ResolveIl2CppType(rawType.GetEncapsulatedType()), referencedFrom)
    {
    }

    public override Il2CppTypeEnum Type => Il2CppTypeEnum.IL2CPP_TYPE_SZARRAY;

    public override string DefaultName => $"{ElementType.Name}[]";
}
