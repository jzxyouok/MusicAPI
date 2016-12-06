﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicAPI.Core
{
    /// <summary>
    /// 请求网易云音乐的接口配置
    /// </summary>
    public static class MusicApiConfig
    {
        /// <summary>
        /// 搜索接口
        /// </summary>
        public class Search : RequestData
        {

             public override string Url 
             { 
                 get
                 {
                     return "http://music.163.com/api/search/get";
                 }
             }

            public override string Method 
            {
                get
                {
                    return "POST";
                }

               set
               {
                  Method = value;
                } 
            }
             
        }

        /// <summary>
        /// 歌曲详情接口
        /// </summary>
        public class Detail : RequestData
        {

            public override string Url
            {
                get
                {
                    return "http://music.163.com/api/song/detail";
                }
            }

        }
    }
}