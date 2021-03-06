﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoAgil.Net
{
    public class PostGenericClass
    {
        string _URI { get; set; }

        public PostGenericClass(string URI)
        {
            _URI = URI;
        }

        private static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }

        public void Post<T>(object obj, ref string resul)
        {
            if (obj == null)
                return;

            var prop = obj.GetType().GetProperties();

            string param = "soft=postgenericClass.net";

            for (int i = 0; i < prop.Count(); i++)
            {
                param += "&" + prop[i].Name + "=" + GetPropValue(obj, prop[i].Name);
            }

            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                wc.Encoding = System.Text.Encoding.UTF8;
                resul = wc.UploadString(_URI, param);

            }

        }


    }
}
