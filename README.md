# RPG game

An old personal RPG being remastered. This repository preserves the original project as a baseline before modernization work begins.

## Project purpose

TBD — original gameplay scope and design goals need investigation (see `Documentation/LEGACY_BASELINE.md`).

## Unity version

**6000.1.15f1** (from `ProjectSettings/ProjectVersion.txt`). Uses the **Universal Render Pipeline (URP 17.1.0)** and the **2D** template packages.

## Current project status

Legacy baseline preserved as-is. Known issues and project structure are documented in `Documentation/LEGACY_BASELINE.md`.

## How to open the project

1. Install Unity **6000.1.15f1** via Unity Hub.
2. Open Unity Hub → Add → select this repository's `RPG_Games/` folder.
3. Let Unity import assets and compile scripts.

## How to run it

Open the scene `Assets/Scenes/MainMenu Ui.unity` or `Assets/Scenes/Game.unity` and press Play. Build settings / target platform: TBD.

## Repository structure

```text
RPG_Games/           Unity project root
  Assets/            Scenes, scripts, prefabs, sprites, settings (tracked)
  Packages/          Package manifest (tracked)
  ProjectSettings/   Unity project settings (tracked)
Documentation/       Development and narrative documentation
```

## Basic development workflow

- `main` holds the preserved legacy baseline (tagged `legacy-baseline`).
- All remaster work happens on the `remaster` branch.
- Commit frequently; never edit the baseline directly.
- `.meta` files must always be committed alongside their assets.

## Known problems

- Needs investigation: compile status, missing assets, broken references — see `Documentation/LEGACY_BASELINE.md`.
