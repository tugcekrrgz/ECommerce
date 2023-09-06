﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Common
{
    public class ImageUploader
    {
        public static string ImageChangeName(string imageName)
        {
            // 0 -> Uymayan Format.
            string newFileName = "";
            string uniqueName=Guid.NewGuid().ToString();
            var fileArray = imageName.Split('.');
            var extension=fileArray[fileArray.Length-1];
            if(extension=="png" || extension=="jpg" || extension == "jpeg")
            {
                newFileName= uniqueName+"."+extension;
                return newFileName;
            }
            else
            {

                return "0";
            }
        }
    }
}