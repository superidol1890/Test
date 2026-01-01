using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Reactor;
using Reactor.Networking;
using Reactor.Networking.Attributes;
using Reactor.Utilities;

namespace Test;

[BepInPlugin("com.SuperIdol.Test", "Test", "1.1.0")]
[BepInProcess("Among Us.exe")]
[BepInDependency(ReactorPlugin.Id)]
[ReactorModFlags(ModFlags.RequireOnAllClients)]
public partial class TestPlugin : BasePlugin
{
    public Harmony Harmony { get; } = new Harmony("Test");
    public const string VersionString = "1.1.0";
    public string OptionsTitleText => "Test";
    public ConfigFile GetConfigFile() => Config;
    public override void Load()
    {
        ReactorCredits.Register("Test", VersionString, false, ReactorCredits.AlwaysShow);
        Harmony.PatchAll();
    }
}