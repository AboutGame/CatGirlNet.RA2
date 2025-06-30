using System.ComponentModel.DataAnnotations;
using CatGirlNet.RA2.Core.Game.Enums;

namespace CatGirlNet.RA2.Core.Game.Config.Side;

public class AiSide : Side
{
    [Required]
    public AiDifficuty Difficulty { get; set; }
}