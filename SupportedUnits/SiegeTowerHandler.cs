namespace AOEOStandardUnitLibrary.SupportedUnits;
public class SiegeTowerHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Sie_SiegeTower_E";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}