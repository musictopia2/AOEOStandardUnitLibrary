namespace AOEOStandardUnitLibrary.SupportedUnits;
public class PriestAmenHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Spc_PriestAmen_E";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}