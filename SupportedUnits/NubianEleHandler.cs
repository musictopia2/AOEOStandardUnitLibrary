namespace AOEOStandardUnitLibrary.SupportedUnits;
public class NubianEleHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Cav_NubianEle_E";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}