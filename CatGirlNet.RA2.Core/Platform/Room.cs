using CatGirlNet.RA2.Core.Game.Config;

namespace CatGirlNet.RA2.Core.Platform;

public class Room
{
    public string RoomName { get; set; }
    
    public List<Player> Players { get; set; } = new();

    public Configs CreateGameConfig()
    {
        throw new NotImplementedException();
    }
}