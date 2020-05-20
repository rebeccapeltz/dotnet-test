using System;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System.IO;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;


namespace myApp
{
    class Program
    {
       static void Main(string[] args)
				{
					static Dictionary<string, string> DeserializeJson (string json)
				{
						return JsonSerializer.Deserialize<Dictionary<string, string>>(json);
				}
					static Dictionary<string, string> GetCredentials()
				{
						using (StreamReader r = new StreamReader("appsetting.json"))
						{
								string json = r.ReadToEnd();
							return DeserializeJson(json);
					}
				}
		var credentials = GetCredentials();
        var myurl = credentials["CLOUDINARY_URL"];
        Console.WriteLine(myurl);
		Cloudinary cloudinary = new Cloudinary(myurl);
        cloudinary.Api.Timeout = int.MaxValue;
		 var explicitParams = new ExplicitParams("sample"){
			  Type = "upload",
		 	  Invalidate = true};
			var explicitResult = cloudinary.Explicit(explicitParams);
            Console.WriteLine(explicitResult.SecureUri);
}
    }
}
