using System;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

using System.Collections.Generic;
using Util;


namespace myApp
{
    class Program
    {
       static void Main(string[] args)
				{
		
		var credentials = Util.Settings.GetCredentials();
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

