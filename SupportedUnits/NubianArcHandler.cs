namespace AOEOStandardUnitLibrary.SupportedUnits;
public class NubianArcHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Arc_NubianArc_E";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}