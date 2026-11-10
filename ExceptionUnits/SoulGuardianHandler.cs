namespace AOEOStandardUnitLibrary.ExceptionUnits;
//NPC_Halloween_Unit_SoulGuardian
public class SoulGuardianHandler : IUnitHandler
{
    public static string SupportedProtoName => "NPC_Halloween_Unit_SoulGuardian";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}
