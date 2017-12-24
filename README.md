# Koxel-AssetBundle-Creator
Unity project to create AssetBundle for mods.

## How to use  
0. Open this project with Unity, I last used 2017.3 but use any version on your own risk (advised is to at least use 5.6 or higher)
1. Create new mod folder in the `Assets` folder (project root).
2. Add your models to this folder (folder structure does not matter).
3. Go back to the `Assets` folder (root of the Project window).
4. Right click on your mod folder and select `Select Depencies` or select all files seperately.
5. In the bottom of the inspector window there is an AssetBundle option.
6. Click on `none` and create a new one called `yourmodname_models` or add it to an existing `modname_models`.
7. This exports an AssetBundle to the `AssetBundles` folder.
8. Copy `yourmodname_models` file (does not have an file extention) to your mod folder for the actual game (`Koxel/Mods/YourModName`)
##### NOTE: `yourmodname` should be *exactly* the same name as your folder name `Koxel/Mods/YourModName` (except for capitals).
