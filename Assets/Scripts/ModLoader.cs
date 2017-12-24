using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ModLoader : MonoBehaviour {

    public static ModLoader instance;

    public List<string> mods;
    public Dictionary<string, Material> materials;
    public Dictionary<string, GameObject> models;
    public Dictionary<string, GameObject> prefabs;

    private string modsfolder;

	void Awake () {
        instance = this;

        materials = new Dictionary<string, Material>();
        models = new Dictionary<string, GameObject>();
        prefabs = new Dictionary<string, GameObject>();

        Setup();
	}
	
	public void Setup()
    {
        modsfolder = Directory.GetParent(Application.dataPath) + "/Mods/";
        foreach (string mod in mods)
        {
            string assetsPath = Path.Combine(Path.Combine(modsfolder, mod), mod.ToLower() + "_models");
            if (File.Exists(assetsPath))
            {
                AssetBundle assets = AssetBundle.LoadFromFile(assetsPath);

                //Material[] mats = assets.LoadAllAssets<Material>();
                //Mesh[] meshs = assets.LoadAllAssets<Mesh>();
                GameObject[] prefabs_ = assets.LoadAllAssets<GameObject>();

                //ImportMaterials(mats);
                //ImportModels(meshs);
                ImportPrefabs(prefabs_);
            }
        }
    }

    public void ImportMaterials(Material[] mats)
    {
        foreach(Material material in mats)
        {
            if (!materials.ContainsKey(material.name))
                materials.Add(material.name, material);
            Debug.Log(material.name);
        }
    }

    public void ImportModels(GameObject[] modelz)
    {
        foreach (GameObject model in modelz)
        {
            if (!models.ContainsKey(model.name))
                prefabs.Add(model.name, model);
            Debug.Log(model.name);
        }
    }

    public void ImportPrefabs(GameObject[] prefabs_)
    {
        foreach (GameObject prefab in prefabs_)
        {
            if (!prefabs.ContainsKey(prefab.name))
                prefabs.Add(prefab.name, prefab);
            //Instantiate(prefab);
            Debug.Log(prefab.name);
        }
        foreach(GameObject go in prefabs.Values)
        {
            Instantiate(go);
        }
    }
}
