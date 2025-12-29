using UnityEngine;

[System.Serializable]
public class ClickKeeperData // Зачем нужен, если есть ClickKeeper
{
    public int _clicks {get; private set;} // Разобраться какие типы полей нужны

    public ClickKeeperData(ClickKeeper clickKeeper) // Тут public потому что конструктор?
    {
        _clicks = clickKeeper._clicks;
    }
}
