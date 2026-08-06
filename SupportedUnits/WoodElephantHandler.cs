namespace AOEOStandardUnitLibrary.SupportedUnits;
public class WoodElephantHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Civ_WoodElephant";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}