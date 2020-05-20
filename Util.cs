using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.IO;


namespace Util
{
  public static class Settings{
    public static Dictionary<string, string> DeserializeJson (string json)
      {
        return JsonSerializer.Deserialize<Dictionary<string, string>>(json);
      }
    public static Dictionary<string, string> GetCredentials()
      {
        using (StreamReader r = new StreamReader("appsetting.json"))
        {
          string json = r.ReadToEnd();
         return DeserializeJson(json);
       }
      }
  }
}