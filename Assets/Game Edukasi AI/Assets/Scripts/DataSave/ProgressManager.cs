using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class ProgressManager : MonoBehaviour, InterfaceSave
{


    //Save Data Element
    public string Username;
    public int UserPoint;
    public int SceneIndex;

    //WelcomePage
    public TMP_InputField Input_Username;
    public TMP_Text Welcome_User;


    //MenuPage
    public TMP_Text WelcomeMenuUser;
    public TMP_Text Menu_Username;
    public TMP_Text Menu_UserPoint;

    
    //Trigger
    [SerializeField] private UnityEvent TriggerHasSaveData;
    [SerializeField] private UnityEvent TriggerHasNotSaveData;
    [SerializeField] private UnityEvent TriggerHasSceneIndexSaved;
    [SerializeField] private UnityEvent TriggerHasNotSceneIndexSaved;

    //GamePlay
    //public QuestProgress questProgressLevel1;
    //public QuestProgress questProgressLevel2;




    void Awake()
    {
        
    }


    void Start()
    {

        if (SaveManager.instance.HasSaveData())
        {
            TriggerHasSaveData.Invoke();
            //QuestSetter();
           

        }
        else
        {
            TriggerHasNotSaveData.Invoke();
            
        }

        

    }

    void Update()
    {   //Welcome Page
        if (Welcome_User != null)
        {
            Welcome_User.text = "Halo " + Username;
        }

        //MainMenu
        if (WelcomeMenuUser != null)
        {
            WelcomeMenuUser.text = "Halo " + Username + ", selamat datang di permainan petualangan & belajar AI.";
        }
        if (Menu_Username != null)
        {
            Menu_Username.text = Username;
        }
        if (Menu_UserPoint != null)
        {
            Menu_UserPoint.text = UserPoint.ToString();
        }

        if(SceneIndex == 0 || SceneIndex == 1 || SceneIndex == 2)
        {
            TriggerHasNotSceneIndexSaved.Invoke();
        }
        else
        {
            TriggerHasSceneIndexSaved.Invoke();
        }

        //QuestGetter();


    }

    public void AddUserPoint(int Point)
    {
        UserPoint = UserPoint + Point;
    }

    public void ResetUserPoint()
    {
        UserPoint = 0;
    }

    //WelcomePage Action
    public void InputUser_name()
    {
        Username = Input_Username.text;

    }

    //Save & Load
    public void SaveData()
    {
        FindObjectOfType<SaveManager>().SaveGame();
    }

    public void DeleteSave()
    {
        FindObjectOfType<SaveManager>().DeleteSaveData();
    }

    public void CreateNewData()
    {
        FindObjectOfType<SaveManager>().CreateNewSaveData();
    }

    //Progress Quest
    public void Add_Quest0Save()
    {
       
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    //public void QuestGetter()
    //{
    //    //int questlength1 = questProgressLevel1.GetLength();
    //    //int questlength2 = questProgressLevel2.GetLength();
    //    for (int i = 0; i < questProgressLevel1.GetLength(); i++)
    //    {
    //        for (int j = 0; j < questProgressLevel1.QuestDataNumber[i].QuestObject.Length; j++)
    //        {
    //            if (questProgressLevel1.QuestDataNumber[i].QuestObject[j] != null)
    //            {
    //                if (questProgressLevel1.QuestDataNumber[i].QuestObject[j].active)
    //                {
    //                    questProgressLevel1.QuestDataNumber[i].QuestActive[j] = true;
    //                }
    //                else
    //                {
    //                    questProgressLevel1.QuestDataNumber[i].QuestActive[j] = false;
    //                }
    //            }
    //        }
    //    }
    //}

    //public void QuestSetter()
    //{
    //    //int questlength1 = questProgressLevel1.GetLength();
    //    //int questlength2 = questProgressLevel2.GetLength();
    //    for (int i = 0; i < questProgressLevel1.GetLength(); i++)
    //    {
    //        for (int j = 0; j < questProgressLevel1.QuestDataNumber[i].QuestActive.Length; j++)
    //        {
    //            if (questProgressLevel1.QuestDataNumber[i].QuestActive[j])
    //            {
    //                if (questProgressLevel1.QuestDataNumber[i].QuestObject[j] != null)
    //                    questProgressLevel1.QuestDataNumber[i].QuestObject[j].SetActive(true);
    //            }
    //            else
    //            {
    //                if (questProgressLevel1.QuestDataNumber[i].QuestObject[j] != null)
    //                    questProgressLevel1.QuestDataNumber[i].QuestObject[j].SetActive(false);
    //            }
    //        }
    //    }
    //}


    //Interface Data To Save & Load
    public void ItfLoadData(SaveData data)
    {
        if (data != null)
        {
            Username = data.playerName;
        }
        if (SaveManager.instance.HasSaveData())
        {
            UserPoint = data.playerPoint;
            SceneIndex = data.SavedIndexScene;
            //questProgressLevel1 = data.questProgressLevel1;
        }




    }

    public void ItfSaveData(ref SaveData data)
    {
        if (Username != null)
        {
            data.playerName = Username;
        }
        if (SaveManager.instance.HasSaveData())
        {
            data.playerPoint = UserPoint;
            //data.questProgressLevel1 = questProgressLevel1;
        }

    }
}
