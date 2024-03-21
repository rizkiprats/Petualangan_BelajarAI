using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StoryTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Story story;

    [SerializeField] private UnityEvent TriggerEventStory;
    public void TriggerStory()
    {
        FindObjectOfType<DialogManager_Story>().StartStoryDialog(story);

        InvokeTriggerStory();
    }

    public void InvokeTriggerStory()
    {
        TriggerEventStory.Invoke();
    }
}
