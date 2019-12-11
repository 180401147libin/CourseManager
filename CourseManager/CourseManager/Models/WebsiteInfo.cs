using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{

    public class WebsiteInfo
    {
        public WebsiteInfo(string sitName, string copyRight)
        {
            SiteName = sitName;
            CopyRight = copyRight;
        }
        public string SiteName { get; set; }

        public string CopyRight { get; set; }
     }
}