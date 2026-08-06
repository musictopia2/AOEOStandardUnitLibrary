namespace AOEOStandardUnitLibrary.SupportedUnits;
public class ConversionPriestHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Spc_ConversionPriest";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}