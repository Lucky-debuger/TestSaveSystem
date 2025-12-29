using TMPro;
using UnityEngine;

public class ClickKeeper : MonoBehaviour
{
    [SerializeField] private TMP_Text textCount;
    [SerializeField] private TMP_Text textSavePath;
    public int _clicks {get; private set;} = 0;

    private void Awake()
    {
        LoadClickKeeper();
    }

    public void SaveClickKeeper()
    {
        SaveSystem.SaveClicksKeeperData(this);
    }

    public void LoadClickKeeper()
    {
        ClickKeeperData data = SaveSystem.LoadClicksKeeperData();

        if (data == null) return;

        _clicks = data._clicks;
        textCount.text = $"Clicks: {_clicks.ToString()}";
        textSavePath.text = $"SavePath: {Application.persistentDataPath.ToString()}";
    }

#region UI Methods
// Зачем нужна штука сверху?
    public void ChangeClicks(int amount)
    {
        _clicks += amount;
        textCount.text = $"Clicks: {_clicks.ToString()}";
    }

#endregion

}
