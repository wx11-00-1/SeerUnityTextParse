public interface IConfigRoot
{
    string fileName { get; }

    void Parse(byte[] bytes);

    bool isNeedUpdate();
}