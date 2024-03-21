using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class DataHandler
{
    private string dataDirPath = "";

    private string dataFileName = "";

    public DataHandler(string dataDirPath, string dataFileName)
    {
        this.dataDirPath = dataDirPath;
        this.dataFileName = dataFileName;
    }


    public SaveData Handler_LoadData()
    {
        string fullPath = Path.Combine(dataDirPath, dataFileName);
        SaveData loadedData = null;
        if (File.Exists(fullPath))
        {
            try
            {
                //memuat serialisasi data dari file save
                string dataToLoad = "";
                using (FileStream stream = new FileStream(fullPath, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        dataToLoad = reader.ReadToEnd();
                    }
                }

                loadedData = JsonUtility.FromJson<SaveData>(dataToLoad);
            }
            catch (Exception e)
            {
                Debug.LogError("Error occured when trying to load data from file" + fullPath + "\n" + e);
            }

        }
        return loadedData;
    }

    public void Handler_SaveData(SaveData data)
    {
        string fullPath = Path.Combine(dataDirPath, dataFileName);
        try
        {
            //Membuat direkrori untuk file save game yang akan ditulis jika belum terbuat
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath));

            //serialisasi data kedalam bentuk file json
            string dataToStore = JsonUtility.ToJson(data, true);

            //proses menulis file kedalam json
            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(dataToStore);
                }
            }

        }
        catch (Exception e)
        {
            Debug.LogError("Error occured when trying to save data to file" + fullPath + "\n" + e);
        }

    }

    public void Handler_DeleteData()
    {
        string fullPath = Path.Combine(dataDirPath, dataFileName);
        if (File.Exists(fullPath))
        {
            try
            {
                File.Delete(fullPath);
            }
            catch (Exception e)
            {
                Debug.LogError("Error occured when trying to Delete data from file" + fullPath + "\n" + e);
            }
        }
    }

}
