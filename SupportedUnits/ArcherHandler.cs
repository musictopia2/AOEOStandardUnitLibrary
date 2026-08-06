namespace AOEOStandardUnitLibrary.SupportedUnits;
public class ArcherHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Arc_Archer4th_L";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}