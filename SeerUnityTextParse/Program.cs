
using System.Text.Encodings.Web;
using System.Text.Json;

const string FOLDER_PATH_RESOURSE = "C:\\Users\\17542\\Downloads\\game\\SeerSkin\\TextAsset\\";
const string FOLDER_PATH_OUTPUT = "C:\\Users\\17542\\Downloads\\game\\SeerSkin\\json\\";

byte[] ReadFileByte(string path)
{
    try
    {
        using FileStream fs = new(path, FileMode.Open, FileAccess.Read);
        byte[] bytes = new byte[fs.Length];
        fs.Read(bytes, 0, bytes.Length);
        return bytes;
    }
    catch
    {
        return null;
    }
}

var serOpt = new JsonSerializerOptions() { Encoder = JavaScriptEncoder.Create(new System.Text.Unicode.UnicodeRange(0, 0x10000)), WriteIndented = true };

if (!Directory.Exists(FOLDER_PATH_OUTPUT))
{
    Directory.CreateDirectory(FOLDER_PATH_OUTPUT);
}

// 解析出错的加入黑名单
HashSet<string> blackList = [
    "ChapterpointTemp",
    "NewMonsterLevelTemp",
    "PvpBanExpert",
    "PvpVote",
    "Redbadge",
    ];

var assemblies = AppDomain.CurrentDomain.GetAssemblies();
foreach (var a in assemblies)
{
    var types = a.GetTypes();
    foreach (var t in types)
    {
        if (!t.IsAbstract && t.Namespace == "core.config")
        {
            if (blackList.Contains(t.Name)) continue;
            try
            {
                var obj = a.CreateInstance(t.FullName);
                var prop = obj.GetType().GetProperty("fileName");
                if (prop == null) continue;
                var fileName = prop.GetValue(obj);
                var data = ReadFileByte($"{FOLDER_PATH_RESOURSE}{fileName}.bytes");
                if (data == null) continue;
                var methods = obj.GetType().GetMethods();
                foreach (var m in methods)
                {
                    if (m.Name == "Parse" && m.GetParameters().Length == 1)
                    {
                        m.Invoke(obj, [data]);
                        File.WriteAllText($"{FOLDER_PATH_OUTPUT}{fileName}.json", JsonSerializer.Serialize(obj.GetType().GetMethod("getItems").Invoke(obj, []), serOpt));
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

Console.WriteLine("ok");
