namespace AOEOStandardUnitLibrary.SupportedUnits;
public class ChampionHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Inf_Champion_E";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}