namespace AOEOStandardUnitLibrary.ExceptionUnits;

public class HeadlessHorsemanHandler : IUnitHandler
{
    public static string SupportedProtoName => "NPC_Halloween_HeadlessHorseman";

    void IUnitHandler.ProcessCustomUnit(XElement root)
    {
        this.RegisterStandardUnit(root);
    }
}
