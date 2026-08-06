namespace AOEOStandardUnitLibrary.SupportedUnits;
public class LongSwordsmanHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Inf_LongSwordsman_E";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}