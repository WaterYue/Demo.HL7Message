﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Demo.HL7MessageParser.Common
{
    /// <summary>
    /// Json帮助类
    /// </summary>
    public static class JsonHelper
    {
        private static Encoding xmlEncode = Encoding.UTF8;
        /// <summary>
        /// 将对象序列化为JSON格式
        /// </summary>
        /// <param name="o">对象</param>
        /// <returns>json字符串</returns>
        public static string ToJson(this object o)
        {
            string json = JsonConvert.SerializeObject(o);
            return json;
        }

        /// <summary>
        /// 解析JSON字符串生成对象实体
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">json字符串(eg.{"ID":"112","Name":"石子儿"})</param>
        /// <returns>对象实体</returns>
        public static T JsonToObject<T>(this string json) where T : class
        {
            JsonSerializer serializer = new JsonSerializer();
            StringReader sr = new StringReader(json);
            object o = serializer.Deserialize(new JsonTextReader(sr), typeof(T));
            T t = o as T;
            return t;
        }

        public static T JsonToObjectFromFile<T>(string path) where T : class
        {
            using (StreamReader reader = new StreamReader(path, xmlEncode))
            {
                JsonSerializer serializer = new JsonSerializer();

                object o = serializer.Deserialize(new JsonTextReader(reader), typeof(T));

                var t = o as T;

                return t;
            }
        }

        /// <summary>
        /// 解析JSON数组生成对象实体集合
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">json数组字符串(eg.[{"ID":"112","Name":"石子儿"}])</param>
        /// <returns>对象实体集合</returns>
        public static List<T> JsonToList<T>(this string json) where T : class
        {
            JsonSerializer serializer = new JsonSerializer();
            StringReader sr = new StringReader(json);
            object o = serializer.Deserialize(new JsonTextReader(sr), typeof(List<T>));
            List<T> list = o as List<T>;
            return list;
        }
    }
}
