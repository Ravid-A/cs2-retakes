using System.Text.Json.Serialization;
using CounterStrikeSharp.API.Modules.Utils;
using RetakesPlugin.Modules.Configs.JsonConverters;
using RetakesPlugin.Modules.Enums;

namespace RetakesPlugin.Modules.Configs;

public class Spawn
{
    public Spawn(Vector absOrigin, QAngle absRotation, QAngle? eyeAngles = null)
    {
        AbsOrigin = absOrigin;
        AbsRotation = absRotation;
        EyeAngles = eyeAngles;
    }

    [JsonConverter(typeof(VectorJsonConverter))]
    public Vector AbsOrigin { get; }
    
    [JsonConverter(typeof(NullableQAngleJsonConverter))]
    public QAngle? AbsRotation { get; }
    
    [JsonConverter(typeof(NullableQAngleJsonConverter))]
    public QAngle? EyeAngles { get; }
    
    public CsTeam Team { get; set; }
    public Bombsite Bombsite { get; set; }
    public bool CanBePlanter { get; set; }
}
