
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

var serOpt = new JsonSerializerOptions() { Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping, WriteIndented = true };

if (!Directory.Exists(FOLDER_PATH_OUTPUT))
{
    Directory.CreateDirectory(FOLDER_PATH_OUTPUT);
}

var assemblies = AppDomain.CurrentDomain.GetAssemblies();
foreach (var a in assemblies)
{
    var types = a.GetTypes();
    foreach (var t in types)
    {
        if (!t.IsAbstract && t.Namespace != null && t.Namespace.StartsWith("core.config"))
        {
            object obj;
            try
            {
                obj = a.CreateInstance(t.FullName);
            }
            catch(Exception e)
            {
                // 创建对象失败
                continue;
            }
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
                    try
                    {
                        m.Invoke(obj, [data]);
                        var getItems = obj.GetType().GetMethod("getItems");
                        File.WriteAllText($"{FOLDER_PATH_OUTPUT}{fileName}.json",
                            JsonSerializer.Serialize(
                                getItems == null ? obj : getItems.Invoke(obj, [])
                            , serOpt));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"{t.Namespace} 解析失败。。。");
                    }
                    break;
                }
            }
        }
    }
}

Console.WriteLine("ok");
