namespace AOEOStandardUnitLibrary.SupportedUnits;
public class WinterMammothHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Cav_WinterMammoth_L";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}