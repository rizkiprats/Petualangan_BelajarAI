using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Add_SoalEntry : MonoBehaviour
{

    public bool addJawabanIsBenar;
    public enum Soallist { Soal0, Soal1, Soal2, Soal3, Soal4 }
    public Soallist soal;
    private int SoalNumber = 0;
    public void AddJawabanIsBenar()
    {

        if (addJawabanIsBenar)
        {
            switch (soal)
            {
                case Soallist.Soal0:

                    GameObject.FindObjectOfType<Action_Soal>().Soal.NomorSoal[0].jawaban[SoalNumber] = true;
                    GameObject.FindObjectOfType<Action_Soal>().soalList = Action_Soal.SoalList.Soal0;
                    break;
                case Soallist.Soal1:

                    GameObject.FindObjectOfType<Action_Soal>().Soal.NomorSoal[1].jawaban[SoalNumber] = true;
                    GameObject.FindObjectOfType<Action_Soal>().soalList = Action_Soal.SoalList.Soal1;
                    break;
                case Soallist.Soal2:

                    GameObject.FindObjectOfType<Action_Soal>().Soal.NomorSoal[2].jawaban[SoalNumber] = true;
                    GameObject.FindObjectOfType<Action_Soal>().soalList = Action_Soal.SoalList.Soal2;
                    break;
                case Soallist.Soal3:

                    GameObject.FindObjectOfType<Action_Soal>().Soal.NomorSoal[3].jawaban[SoalNumber] = true;
                    GameObject.FindObjectOfType<Action_Soal>().soalList = Action_Soal.SoalList.Soal3;
                    break;
                case Soallist.Soal4:

                    GameObject.FindObjectOfType<Action_Soal>().Soal.NomorSoal[4].jawaban[SoalNumber] = true;
                    GameObject.FindObjectOfType<Action_Soal>().soalList = Action_Soal.SoalList.Soal4;
                    break;
            }

        }
        else
        {
            switch (soal)
            {
                case Soallist.Soal0:

                    GameObject.FindObjectOfType<Action_Soal>().Soal.NomorSoal[0].jawaban[SoalNumber] = false;
                    GameObject.FindObjectOfType<Action_Soal>().soalList = Action_Soal.SoalList.Soal0;
                    break;
                case Soallist.Soal1:

                    GameObject.FindObjectOfType<Action_Soal>().Soal.NomorSoal[1].jawaban[SoalNumber] = false;
                    GameObject.FindObjectOfType<Action_Soal>().soalList = Action_Soal.SoalList.Soal1;
                    break;
                case Soallist.Soal2:

                    GameObject.FindObjectOfType<Action_Soal>().Soal.NomorSoal[2].jawaban[SoalNumber] = false;
                    GameObject.FindObjectOfType<Action_Soal>().soalList = Action_Soal.SoalList.Soal2;
                    break;
                case Soallist.Soal3:

                    GameObject.FindObjectOfType<Action_Soal>().Soal.NomorSoal[3].jawaban[SoalNumber] = false;
                    GameObject.FindObjectOfType<Action_Soal>().soalList = Action_Soal.SoalList.Soal3;
                    break;
                case Soallist.Soal4:

                    GameObject.FindObjectOfType<Action_Soal>().Soal.NomorSoal[4].jawaban[SoalNumber] = false;
                    GameObject.FindObjectOfType<Action_Soal>().soalList = Action_Soal.SoalList.Soal4;
                    break;
            }

        }

    }
}
