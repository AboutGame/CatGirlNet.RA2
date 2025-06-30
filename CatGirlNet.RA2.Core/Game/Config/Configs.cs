namespace CatGirlNet.RA2.Core.Game.Config;

public class Configs
{
    public required LaunchConfig LaunchConfig { get; set; }
    
    public required GameModeConfig GameModeConfig { get; set; }
    
    public required LocalGameConfig LocalGameConfig { get; set; }
    
    public required NetworkConfig NetworkConfig { get; set; }
}