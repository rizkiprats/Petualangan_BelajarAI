using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class InputCheck : MonoBehaviour
{
    // Start is called before the first frame update
    TMP_InputField input;
    [SerializeField] private UnityEvent TriggerInputTrue;
    [SerializeField] private UnityEvent TriggerInputFalse;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        input = this.gameObject.GetComponent<TMP_InputField>();

        if (input.text == "")
        {
            TriggerInputFalse.Invoke();
        } else
        {
            TriggerInputTrue.Invoke();
        }
    }
}
