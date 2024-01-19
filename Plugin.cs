using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using LCWalkieInterferenceMod.Patches;

namespace LCWalkieInterferenceMod;

public static class PluginInfo
{
    public const string modGUID = "suskitech.LCWalkieInterference";
    public const string modName = "LC Walkie Interference";
    public const string modVersion = "1.0.0";
}

[BepInPlugin(PluginInfo.modGUID, PluginInfo.modName, PluginInfo.modVersion)]
public class Plugin : BaseUnityPlugin
{
    private ConfigEntry<float> configAudibleDistance;
    public static float AudibleDistance;

    private ConfigEntry<float> configWalkieRecordingRange;
    public static float WalkieRecordingRange;

    private ConfigEntry<float> configPlayerToPlayerSpatialHearingRange;
    public static float PlayerToPlayerSpatialHearingRange;

    public static ManualLogSource Log;

    private static Plugin Instance;

    public void Awake()
    {
        if (Instance == null) {
            Instance = this;
        }

        configAudibleDistance = Config.Bind("General", "AudibleDistance", 12f, "");
        AudibleDistance = configAudibleDistance.Value;

        configWalkieRecordingRange = Config.Bind("General", "WalkieRecordingRange", 20f, "");
        WalkieRecordingRange = configWalkieRecordingRange.Value;

        configPlayerToPlayerSpatialHearingRange = Config.Bind("General", "PlayerToPlayerSpatialHearingRange", 20f, "");
        PlayerToPlayerSpatialHearingRange = configPlayerToPlayerSpatialHearingRange.Value;

        Log = BepInEx.Logging.Logger.CreateLogSource(PluginInfo.modGUID);

        Harmony harmony = new(PluginInfo.modGUID);

        harmony.PatchAll(typeof(Plugin));
        harmony.PatchAll(typeof(PlayerControllerBPatch));
        harmony.PatchAll(typeof(WalkieTalkiePatch));

        Log.LogInfo("\\ /");
        Log.LogInfo("/|\\");
        Log.LogInfo(" |----|");
        Log.LogInfo(" |[__]| Walkie Interference");
        Log.LogInfo($" |.  .| Version {PluginInfo.modVersion} Loaded");
        Log.LogInfo(" |____|");
        Log.LogInfo("");
        Log.LogInfo("AudibleDistance: " + AudibleDistance);
        Log.LogInfo("WalkieRecordingRange: " + WalkieRecordingRange);
        Log.LogInfo("PlayerToPlayerSpatialHearingRange: " + PlayerToPlayerSpatialHearingRange);
    }
}
