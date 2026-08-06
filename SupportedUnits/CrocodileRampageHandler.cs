namespace AOEOStandardUnitLibrary.SupportedUnits;
public class CrocodileRampageHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Inf_CrocodileRampage";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}