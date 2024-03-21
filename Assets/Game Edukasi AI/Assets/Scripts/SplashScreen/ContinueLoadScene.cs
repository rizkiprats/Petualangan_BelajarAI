using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueLoadScene : MonoBehaviour
{
    [Header("Main Settings")]
    public int TargetScene;
    public float Delay;

    void LoadTheScene()
    {
        //Melakukan perpindahan antar scene. Catatan: Scene yang dipanggil sudah didaftarkan di Build Setting
        SceneManager.LoadScene(TargetScene);
    }

    public void CountinueGame()
    {
        Time.timeScale = 1;
        Invoke("LoadTheScene", Delay);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TargetScene = FindObjectOfType<ProgressManager>().SceneIndex;
    }

   
}
