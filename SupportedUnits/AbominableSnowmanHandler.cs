namespace AOEOStandardUnitLibrary.SupportedUnits;
public class AbominableSnowmanHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Npc_AbominableSnowman_L";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}