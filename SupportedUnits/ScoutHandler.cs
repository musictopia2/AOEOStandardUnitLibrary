namespace AOEOStandardUnitLibrary.SupportedUnits;
public class ScoutHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Cav_Scout";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}