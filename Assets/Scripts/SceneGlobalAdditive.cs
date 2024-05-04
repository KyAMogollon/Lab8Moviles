using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneGlobalAdditive : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    public void CargarEscena(SceneAsset scene)
    {
        SceneManager.LoadSceneAsync(scene.name,LoadSceneMode.Additive);
    }
    public void DescargarEscena(SceneAsset scene)
    {
        SceneManager.UnloadSceneAsync(scene.name);
    }
}
