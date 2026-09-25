# Legacy Baseline — Project State Before Remaster

Date of baseline: **2026-09-25**

## Unity version

- **6000.1.15f1** (from `ProjectSettings/ProjectVersion.txt`)
- Packages: URP 17.1.0, Cinemachine 3.1.4, Input System 1.14.0, 2D suite (animation/aseprite/psdimporter/sprite/spriteshape/tilemap), Timeline 1.8.9, Visual Scripting 1.9.7, uGUI 2.0.0
- Project template: 2D (`m_DefaultBehaviorMode: 1` in EditorSettings.asset)

## Operating environment

- Linux (CachyOS, kernel 6.18.52-1-cachyos-lts)
- Git identity: katsukii Neko

## Asset inventory (rough counts, before remaster)

- Scripts (`Assets/scripts/`): 39 `.cs` files
- Scenes: 35 `.unity` files (2 in `Assets/Scenes/`: `MainMenu Ui.unity`, `Game.unity` — remaining scenes elsewhere under Assets)
- Prefabs: 7 `.prefab` files
- ScriptableObjects/other `.asset`: 153
- PNGs: 15
- FBX: 0; audio (.wav/.mp3/.ogg/.mp4): 0
- Top-level Assets folders: `animation`, `physic2d`, `PreLabs`, `Resources`, `Scenes`, `scripts`, `Settings`, `sprites`, `TextMesh Pro`, `tile`, `Timeline`, `TimeLine Assets`

## Major existing scenes

- `Assets/Scenes/MainMenu Ui.unity` (main menu UI)
- `Assets/Scenes/Game.unity` (game scene)
- Other scene locations: Needs investigation

## Major existing systems

- Needs investigation — Phase 1 (archaeology) will map the 39 scripts and gameplay systems.

## Known compile errors

- Unknown — verified by opening the project in Unity 6000.1.15f1 (see Phase 0 Step 17).

## Known runtime errors

- Unknown.

## Known missing assets

- Unknown — reference integrity needs investigation.

## Known broken references

- Unknown — scripts referencing missing assets will surface as compile/import issues.

## Git history at baseline

- No pre-existing Git repository or history. Repository initialized at baseline commit (tagged `legacy-baseline`).
- Existing remote: none found on disk; `origin` set to `git@github.com:KatsukiiNeko/RPG_game_remaster.git` per developer instruction.

## Large files

- None over 10 MB found in `Assets/`. No LFS migration needed at this time.

## Potential technical risks

- 35 scattered scenes may contain duplicates/experiments — Phase 1 must identify which are authoritative.
- Mixed folder naming conventions (`scripts` vs `PreLabs` vs `TimeLine Assets`) suggest informal organization.
- Build target platform not yet confirmed.
- Git LFS not installed on this machine — if large binary assets are added later, install LFS before committing them.
