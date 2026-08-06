namespace AOEOStandardUnitLibrary.SupportedUnits;
public class SlingerHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Arc_Slinger_E";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}