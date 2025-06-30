using CatGirlNet.RA2.Core.Platform;

namespace CatGirlNet.RA2.Core.Protocol.Common;

public class PlayerChat
{
    public required Player Player { get; set; }
    
    public required string Content { get; set; }
}