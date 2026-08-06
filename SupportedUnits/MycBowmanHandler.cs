namespace AOEOStandardUnitLibrary.SupportedUnits;
public class MycBowmanHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Arc_MycBowman_E";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}