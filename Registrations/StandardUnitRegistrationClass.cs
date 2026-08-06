namespace AOEOStandardUnitLibrary.Registrations;
public class StandardUnitRegistrationClass : IUnitRegistry
{
    IUnitHandler? IUnitRegistry.GetHandlerFor(string protoName)
    {
        if (protoName == ArcherHandler.SupportedProtoName)
        {
            return new ArcherHandler();
        }
        if (protoName == MycBowmanHandler.SupportedProtoName)
        {
            return new MycBowmanHandler();
        }
        if (protoName == HippikonHandler.SupportedProtoName)
        {
            return new HippikonHandler();
        }
        if (protoName == MycHopliteHandler.SupportedProtoName)
        {
            return new MycHopliteHandler();
        }
        if (protoName == SpearmanHandler.SupportedProtoName)
        {
            return new SpearmanHandler();
        }
        if (protoName == SiegeTowerHandler.SupportedProtoName)
        {
            return new SiegeTowerHandler();
        }
        if (protoName == PriestAmenHandler.SupportedProtoName)
        {
            return new PriestAmenHandler();
        }
        if (protoName == NubianArcHandler.SupportedProtoName)
        {
            return new NubianArcHandler();
        }
        if (protoName == NubianEleHandler.SupportedProtoName)
        {
            return new NubianEleHandler();
        }
        if (protoName == WoadRaiderHandler.SupportedProtoName)
        {
            return new WoadRaiderHandler();
        }
        if (protoName == LongSwordsmanHandler.SupportedProtoName)
        {
            return new LongSwordsmanHandler();
        }
        if (protoName == SlingerHandler.SupportedProtoName)
        {
            return new SlingerHandler();
        }
        if (protoName == HorsemanHandler.SupportedProtoName)
        {
            return new HorsemanHandler();
        }
        if (protoName == ChampionHandler.SupportedProtoName)
        {
            return new ChampionHandler();
        }
        if (protoName == GaesataeHandler.SupportedProtoName)
        {
            return new GaesataeHandler();
        }
        if (protoName == WolfBerserkerHandler.SupportedProtoName)
        {
            return new WolfBerserkerHandler();
        }
        if (protoName == WoodElephantHandler.SupportedProtoName)
        {
            return new WoodElephantHandler();
        }
        if (protoName == HeadHunterHandler.SupportedProtoName)
        {
            return new HeadHunterHandler();
        }
        if (protoName == ConversionPriestHandler.SupportedProtoName)
        {
            return new ConversionPriestHandler();
        }
        if (protoName == CrocodileRampageHandler.SupportedProtoName)
        {
            return new CrocodileRampageHandler();
        }
        if (protoName == PalintononHandler.SupportedProtoName)
        {
            return new PalintononHandler();
        }
        if (protoName == ScoutHandler.SupportedProtoName)
        {
            return new ScoutHandler();
        }
        if (protoName == AbominableSnowmanHandler.SupportedProtoName)
        {
            return new AbominableSnowmanHandler();
        }
        if (protoName == MummyFighterHandler.SupportedProtoName)
        {
            return new MummyFighterHandler();
        }
        if (protoName == WinterMammothHandler.SupportedProtoName)
        {
            return new WinterMammothHandler();
        }
        return null;
    }
}