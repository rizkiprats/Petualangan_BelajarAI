using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;
using System.IO;

public class DataSaveManager : MonoBehaviour
{
    [Header("File Storage Config")]
    [SerializeField] private string fileName;

    private GameDataSave gameDataSave;

    private List<InterfaceDataSave> dataSaveObjects;

    private FileDataHandler dataHandler;

    public static DataSaveManager instance { get; private set; }


    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Found more than one Data Persistent Manager in the scene.");
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this);

        this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName);
    }


    public void NewGame()
    {
        this.gameDataSave = new GameDataSave();
    }

    public void LoadGame()
    {

        this.gameDataSave = dataHandler.Load();

        if(this.gameDataSave == null)
        {
            Debug.Log("No data was found. A New Game needs to be started before data can be loaded");
            //NewGame();
        }

        foreach (InterfaceDataSave dataSaveObj in dataSaveObjects)
        {
            dataSaveObj.LoadData(gameDataSave);
        }
        //Debug.Log("Loaded timer = " + gameDataSave.timer);
        Debug.Log("Game Loaded");


    }

    public void SaveGame()
    {

        if (this.gameDataSave == null)
        {
            Debug.Log("No data was found. A New Game needs to be started before data can be loaded");
            return;
        }

        foreach (InterfaceDataSave dataSaveObj in dataSaveObjects)
        {
            dataSaveObj.SaveData(ref gameDataSave);
            
        }
        //Debug.Log("Saved timer = " + gameDataSave.timer);

        dataHandler.Save(gameDataSave);

        Debug.Log("Game Saved");

    }

    public void DeleteSaveGame()
    {
        SceneManager.LoadScene(0);
        


    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.sceneUnloaded += OnSceneUnLoaded;

    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
        SceneManager.sceneUnloaded -= OnSceneUnLoaded;

    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnScene Loaded Called");
        this.dataSaveObjects = FindAllDataSaveObjects();
        LoadGame();
    }

    public void OnSceneUnLoaded(Scene scene)
    {
        Debug.Log("OnScene UnLoaded Called");
        SaveGame();
    }

    private void Start()
    {
        //this.dataSaveObjects = FindAllDataSaveObjects();
        //LoadGame();

    }

    private void OnApplicationQuit()
    {
        //SaveGame(); 
    }

    private  List<InterfaceDataSave> FindAllDataSaveObjects()
    {
        IEnumerable<InterfaceDataSave> dataSaveObjects = FindObjectsOfType<MonoBehaviour>().OfType<InterfaceDataSave>();
        return new List<InterfaceDataSave>(dataSaveObjects);
    }

    public bool HasGameData()
    {
        return gameDataSave != null;
    }

}
