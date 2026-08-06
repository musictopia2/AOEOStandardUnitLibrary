namespace AOEOStandardUnitLibrary.SupportedUnits;
public class HorsemanHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Cav_Horseman_E";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}