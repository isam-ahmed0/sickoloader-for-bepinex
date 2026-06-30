# SickoLoader for BepInEx

![Preview](https://github.com/isam-ahmed0/sickoloader-for-bepinex/blob/main/Screenshot%20(151).png?raw=true)

A **BepInEx IL2CPP plugin** that loads SickoMenu safely alongside other BepInEx mods — no more crashes.

## The Problem

SickoMenu (the original `.dll`) relies on `version.dll` trickery which conflicts with BepInEx, causing crashes when both are present.

## The Solution

SickoLoader is a proper BepInEx plugin that calls `LoadLibrary("SickoMenu.dll")` at the right moment during game startup. This lets SickoMenu run **inside** the BepInEx environment without conflicts.

## Features

- **No crashes** — works with BepInEx-based mods, menus, plugins (Hydra, etc.)
- **Lightweight** — single DLL, zero dependencies beyond BepInEx itself
- **Clean load** — no `version.dll` needed in the game folder

## Installation

**Method 1 is mstore, xbox, epic games(x64) based. I didnt tried it in x86(steam, itch) and method 1 is recommended and easy installation.**

### Method 1 — Quick install(Recomended for x64)

**This installation contains contains Bepinex, sickomenu, configs and hydramenu.**
1. Download [sfb-full.zip](https://github.com/isam-ahmed0/sickoloader-for-bepinex/releases)
2. Extract directly into your Among Us folder
3. Run the game
4. Use Delete key for sickomenu and Insert for hydra.

### Method 2 — Manual setup

### Requirements

- [BepInEx](https://github.com/BepInEx/BepInEx/releases) (IL2CPP variant) for Among Us
- [SickoMenu](https://github.com/g0aty/SickoMenu/releases) `.dll`

#### Step 1: Install BepInEx

Download the latest [BepInEx](https://github.com/BepInEx/BepInEx/releases) (IL2CPP version) and extract it into your Among Us folder.

#### Step 2: Add SickoMenu

Download and extract [SickoMenu](https://github.com/g0aty/SickoMenu/releases). Copy only `SickoMenu.dll`(from ./BepInEx/plugins) and `config folder` into the Among Us folder.

**Do NOT copy or place `version.dll` anywhere in the Among Us folder.**

#### Step 3: Add SickoLoader

Download the latest `SickoLoader.dll` from [Releases](https://github.com/isam-ahmed0/sickoloader-for-bepinex/releases) and copy it to `Among Us/BepInEx/plugins/`.

## Building from Source

```bash
dotnet build SickoLoader/SickoLoader.csproj
```

Requires .NET 6.0 SDK and BepInEx assemblies referenced in the project (update the hint paths in `SickoLoader.csproj` to point to your local Among Us installation).

## Credits

- [g0aty](https://github.com/g0aty) — SickoMenu
- [BepInEx](https://github.com/BepInEx/BepInEx) team — the modding framework
