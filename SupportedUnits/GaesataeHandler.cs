namespace AOEOStandardUnitLibrary.SupportedUnits;
public class GaesataeHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Arc_Gaesatae_E";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}