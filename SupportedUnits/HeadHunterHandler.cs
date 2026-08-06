namespace AOEOStandardUnitLibrary.SupportedUnits;
public class HeadHunterHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Cav_HeadHunter_E";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}