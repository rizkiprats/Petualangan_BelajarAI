using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckStory : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isstoryEnd;
    [SerializeField] private UnityEvent TriggerEventStoryEnd;
    public bool isquestEnd;
    [SerializeField] private UnityEvent TriggerEventQuestEnd;

    public GameObject QuestTrigger;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isstoryEnd = GameObject.FindObjectOfType<DialogManager_Story>().isStoryEnd;
        isquestEnd = GameObject.FindObjectOfType<DialogManager_Quest>().isquestEnd;

        if (isstoryEnd)
        {
            ActivateQuest();

        }

        if (isquestEnd)
        {
            DisableQuest();
        }
    }

    public void ActivateQuest()
    {
        if (QuestTrigger != null)
        {
            QuestTrigger.gameObject.SetActive(true);
            
        }
        TriggerEventStoryEnd.Invoke();
    }

    public void DisableQuest()
    {
        if (QuestTrigger != null)
        {
            QuestTrigger.gameObject.SetActive(false);
        }
        TriggerEventQuestEnd.Invoke();
    }


}
