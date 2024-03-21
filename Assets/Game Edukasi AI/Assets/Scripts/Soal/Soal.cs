using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Soal
{
    [System.Serializable]
    public struct JawabanSoal
    {
        public bool[] jawaban;
    }

    public JawabanSoal[] NomorSoal = new JawabanSoal[5];

   
}
