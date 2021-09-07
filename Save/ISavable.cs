namespace _Project.Scripts
{
    public interface ISavable
    {
        object SaveData();

        void LoadData(object data);
    }
}