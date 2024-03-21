using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MateriTest : MonoBehaviour
{
    public MateriDataList materi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(materi.materiListData.Length);
    }
}
