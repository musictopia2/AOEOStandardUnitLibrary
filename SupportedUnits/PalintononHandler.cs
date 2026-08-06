namespace AOEOStandardUnitLibrary.SupportedUnits;
public class PalintononHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Sie_Palintonon";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}