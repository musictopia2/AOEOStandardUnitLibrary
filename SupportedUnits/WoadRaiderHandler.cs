namespace AOEOStandardUnitLibrary.SupportedUnits;
public class WoadRaiderHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Inf_WoadRaider_E";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}