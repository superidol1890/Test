using BepInEx;
using BepInEx.Unity.IL2CPP;
using Reactor;
using Reactor.Networking;
using Reactor.Networking.Attributes;

namespace Test;

[BepInPlugin("com.test.mod", "Test Plugin", "1.0.0")]
[BepInProcess("Among Us.exe")]
[BepInDependency(ReactorPlugin.Id)]
[ReactorModFlags(ModFlags.RequireOnAllClients)] 
public partial class TestPlugin : BasePlugin 
{
    public override void Load()
    {
        Log.LogInfo("Test Mod 1.0.0 is officially registered and visible!");
    }
}