using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Action_Soal : MonoBehaviour
{
    public enum SoalList { NoneSoal, Soal0, Soal1, Soal2, Soal3, Soal4 }

    public SoalList soalList;

    public Soal Soal;

    [SerializeField]private bool Lulus;

    [SerializeField] private UnityEvent TriggerLulus;
    [SerializeField] private UnityEvent TriggerGagal;

    // Start is called before the first frame update
    void Start()
    {
        soalList = SoalList.NoneSoal;
        if (Soal.NomorSoal.Length > 5)
        {
            Soal.NomorSoal = new Soal.JawabanSoal[5];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        switch (soalList)
        {
            case SoalList.NoneSoal:
                Lulus = false;
                break;
            case SoalList.Soal0:
                for (int i = 0; i < Soal.NomorSoal[0].jawaban.Length; i++)
                {
                    if (Soal.NomorSoal[0].jawaban[i])
                    {
                        Soal.NomorSoal[0].jawaban[i] = true;
                    }
                    else
                    {
                        Soal.NomorSoal[0].jawaban[i] = false;
                    }
                }
                break;
            case SoalList.Soal1:
                for (int i = 0; i < Soal.NomorSoal[1].jawaban.Length; i++)
                {
                    if (Soal.NomorSoal[1].jawaban[i])
                    {
                        Soal.NomorSoal[1].jawaban[i] = true;
                    }
                    else
                    {
                        Soal.NomorSoal[1].jawaban[i] = false;
                    }
                }
                break;
            case SoalList.Soal2:
                for (int i = 0; i < Soal.NomorSoal[2].jawaban.Length; i++)
                {
                    if (Soal.NomorSoal[2].jawaban[i])
                    {
                        Soal.NomorSoal[2].jawaban[i] = true;
                    }
                    else
                    {
                        Soal.NomorSoal[2].jawaban[i] = false;
                    }
                }
                break;
            case SoalList.Soal3:
                for (int i = 0; i < Soal.NomorSoal[3].jawaban.Length; i++)
                {
                    if (Soal.NomorSoal[3].jawaban[i])
                    {
                        Soal.NomorSoal[3].jawaban[i] = true;
                    }
                    else
                    {
                        Soal.NomorSoal[3].jawaban[i] = false;
                    }
                }
                break;
            case SoalList.Soal4:
                for (int i = 0; i < Soal.NomorSoal[4].jawaban.Length; i++)
                {
                    if (Soal.NomorSoal[4].jawaban[i])
                    {
                        Soal.NomorSoal[4].jawaban[i] = true;
                    }
                    else
                    {
                        Soal.NomorSoal[4].jawaban[i] = false;
                    }
                }
                break;
        }

        Lulus = CheckAllAnswerTrue();
               

    }

    private bool CheckAllAnswerTrue()
    {
        for (int i = 0; i < Soal.NomorSoal.Length; i++)
        {
            if (Soal.NomorSoal[i].jawaban[0] == false)
            {
                return false;
            }
        }

        return true;
    }

    public void voidCheckJawaban() {

        if (Lulus)
        {
            InvokeTriggerLulus();
        }
        else
        {
            InvokeTriggerGagal();
        }
    }

    public void InvokeTriggerLulus()
    {
        TriggerLulus.Invoke();
    }

    public void InvokeTriggerGagal()
    {
        TriggerGagal.Invoke();
    }
}
