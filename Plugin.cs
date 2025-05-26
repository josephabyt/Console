using BepInEx;
using UnityEngine;

namespace Console
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Start() =>
            GorillaTagger.OnPlayerSpawned(OnPlayerSpawned);

        void OnPlayerSpawned()
        {
            string ConsoleGUID = $"goldentrophy_Console_{Console.ConsoleVersion}";
            GameObject ConsoleObject = GameObject.Find(ConsoleGUID);

            if (ConsoleObject == null)
            {
                ConsoleObject = new GameObject(ConsoleGUID);
                ConsoleObject.AddComponent<Console>();
            }

            if (ServerData.ServerDataEnabled)
                ConsoleObject.AddComponent<ServerData>();
        }
    }
}
