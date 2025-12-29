using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; // Разобраться с прастранствами имен и зачем они нужны

public static class SaveSystem // Стоит ли делать staic? И зачем?
{
    public static void SaveClicksKeeperData(ClickKeeper clickKeeper)
    {
        BinaryFormatter formatter = new BinaryFormatter(); // Еще раз что это?
        string path = Application.persistentDataPath + "/ClickKeeper.myformat";
        Debug.Log(Application.persistentDataPath);
        FileStream stream = new FileStream(path, FileMode.Create); // Разобраться, что строка
        ClickKeeperData data = new ClickKeeperData(clickKeeper);

        formatter.Serialize(stream, data); // Что это?
        stream.Close(); // Зачем его закрывать? А когда мы его открыли?
    }

    public static ClickKeeperData LoadClicksKeeperData()
    {
        string path = Application.persistentDataPath + "/ClickKeeper.myformat"; // Что такое persistentDataPath?

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ClickKeeperData data = formatter.Deserialize(stream) as ClickKeeperData; // Что такое cast? И вообще зачем тут писать as?
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}