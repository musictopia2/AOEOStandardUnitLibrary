namespace AOEOStandardUnitLibrary.SupportedUnits;
public class HippikonHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Cav_Hippikon4th_L";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}