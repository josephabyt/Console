<p align="center">
  <a href="#"><img src="https://i.imgur.com/INWslSU.png"></a>
</p>

---

<p align="center">
	<a href="https://github.com/iiDk-the-actual/Console/releases"><img src="https://img.shields.io/github/v/release/iiDk-the-actual/Console?label=version&style=for-the-badge"></a>
	<a href="https://github.com/iiDk-the-actual/Console/releases/latest"><img src="https://img.shields.io/github/downloads/iiDk-the-actual/Console/latest/Console.dll?style=for-the-badge"></a>
	<a href="https://discord.gg/ccyF7HjzFX"><img src="https://img.shields.io/discord/1284355047907528725?label=discord&style=for-the-badge&color=blueviolet"></a>
</p>

---

# 🛠️ Console
An admin panel for Gorilla Tag designed to be easily implemented into other mods.

---

## 📘 What is Console?

**Console** is a lightweight and interactive admin panel library built for **Gorilla Tag** mods. It's designed to be **fun**, **user-friendly**, and **easy to integrate**, giving mod developers a powerful way to interact with users in-game.

Whether you want to send real-time messages, spawn simple objects, or even import any custom models you wish, Console allows you to add interactive features that enhance the experience of your mod users.

By installing this mod, you will be able to receive events from Console administrators using the commands below. You will not be able to execute these commands without authority.

---

## ✨ Features

* ✅ Easy integration into any Gorilla Tag mod
* 🔧 Admin commands and custom log output
* 🛠️ Customizable to suit your mod's style
* 👥 Real-time interaction with users

---

# 📥 Installation 
1️⃣ **Download** the latest release 👉 [here](https://github.com/iiDk-the-actual/Console/releases/latest)  
2️⃣ **Drag & Drop** `Console.dll` into your **plugins** folder  
3️⃣ **Launch** Gorilla Tag and enjoy!

---

## 🔧 Implementation (For Developers)

1. Drag all files from Console (except Plugin.cs and PluginInfo.cs) into your project under a folder
3. Modify the configuration of Console.cs and ServerData.cs in the "Configuration" regions
3. Add this snippet of code into your BaseUnityPlugin (from Plugin.cs):
```csharp
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
```

---

## 🧪 Example Usage

To execute Console commands, you can use the `Console.ExecuteCommand()` method with its given parameters. Here is the list of all working commands:

- `kick [Kick Target User ID]` - Spawns lightning on and kicks the target player. Send as all for the lightning to network.
- `silkick [Kick Target User ID]` - Kicks the target player with no effects.
- `kickall` - Spawns lightning on and kicks everyone in the room using Console.

- `join [Room Name]` - Makes the receiver join the specified room.

- `isusing` - Used to find other people using Console. Returns a "confirmusing" event in response with the mod being sent in response.
- `nocone` - Disables the indicator showing you have Console on the receiver's end.

- `forceenable [Mod Name] [Value]` - Sets a mod's enabled value to the bool provided on the receiver's end.
- `toggle [Mod Name]` - Toggles a mod on or off on the receiver's end.
- `togglemenu [Toggle]` - Toggles their menu on or off on the receiver's end.
- `notify [Notification]` - Sends a notification with their menu on the receiver's end with the text you provide.

- `tp [Position]` - Teleports the receiver to the position provided.
- `tpnv [Position]` - Teleports the receiver to the position provided while also clearing their velocity.
- `vel [Velocity]` - Sets the receiver's velocity to the vector provided.

- `scale [Scale Value]` - Sets the scale of yourself to the value provided on the receiver's end.
- `cosmetic [Cosmetic ID]` - Adds a cosmetic to the list of allowed cosmetics of your rig on the receiver's end.

- `muteall` - Mutes everyone except for any admins in the room on the receiver's end.
- `unmuteall` - Unmutes everyone in the room on the receiver's end.

- `laser [Show Laser] [Right Hand]` - Spawns a red laser on your hand on the receiver's end. It faces down the palm of your hand.
- `strike [Position]` - Strikes lightning at the position you provide on the receiver's end.

- `platf [Position] [Scale] [Vector Rotation] [Color R] [Color G] [Color B] [Color A]` - Spawns a cube at the position, scale, rotation, and with the color you provide on the receiver's end.
- `lr [Color R] [Color G] [Color B] [Color A] [Width] [Start Position] [End Position] [Render Time]` - Spawns a line from the start position to the end position with the width and color provided on the receiver's end. It will destroy after the render time in seconds.
---

## 🧑‍💻 Contributing

Pull requests are welcome! If you have suggestions for features or improvements, feel free to open an issue or submit a pull request.
