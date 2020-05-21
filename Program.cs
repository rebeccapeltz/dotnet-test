using System;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using dotenv.net;

namespace myApp
{
    class Program
    {
       static void Main(string[] args)
		{
            DotEnv.Config();
            var myurl = Environment.GetEnvironmentVariable("CLOUDINARY_URL");
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