namespace AOEOStandardUnitLibrary.SupportedUnits;
public class MycHopliteHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Inf_MycHoplite_E";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}