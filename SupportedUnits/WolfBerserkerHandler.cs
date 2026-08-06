namespace AOEOStandardUnitLibrary.SupportedUnits;
public class WolfBerserkerHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Inf_WolfBerserker";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}