namespace AOEOStandardUnitLibrary.SupportedUnits;
public class MummyFighterHandler : IUnitHandler
{
    public static string SupportedProtoName => "Con_Npc_MummyFighter_L";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}