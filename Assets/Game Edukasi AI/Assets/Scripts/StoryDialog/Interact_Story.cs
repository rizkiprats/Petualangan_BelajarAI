using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact_Story : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            this.gameObject.GetComponent<StoryTrigger>().TriggerStory();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            GameObject.FindObjectOfType<DialogManager_Story>().isStoryEnd = false;
            GameObject.FindObjectOfType<DialogManager_Quest>().isquestEnd = false;
        }
    }

    public void ResetStory()
    {
        GameObject.FindObjectOfType<DialogManager_Story>().isStoryEnd = false;
        GameObject.FindObjectOfType<DialogManager_Quest>().isquestEnd = false;
    }


}
