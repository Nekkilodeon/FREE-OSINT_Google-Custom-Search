using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class SocialNetworkLib
    {
        public class SocialNetworkWindowInfo
        {
            public string title = "";
            public List<Result> results { get; set; }

            public SocialNetworkWindowInfo(string title, List<Result> results)
            {
                this.title = title;
                this.results = results;
            }
        }
    }

}
