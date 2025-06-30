using System.Net;

namespace CatGirlNet.RA2.Core.Game.Config.Side;

public class RemoteSide : Side
{
    // We're always use tunnel.
    public IPAddress? Ip { get; } = null;

    public required ushort Port { get; set; } = Constants.RemotePlayer1Port;
}