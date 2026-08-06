namespace AOEOStandardUnitLibrary.SupportedUnits;
public class SpearmanHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Inf_Spearman4th_L";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}