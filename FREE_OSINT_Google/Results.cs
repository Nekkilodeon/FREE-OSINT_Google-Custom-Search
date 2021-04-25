using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace Models
{
    public class Result
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Snippet { get; set; }
        public string Source { get; set; }
        public string Query { get; set; }
        public int Index { get; set; }
        public TreeNode Metadata { get; internal set; }

        public override string ToString()
        {
            return Title;
        }

        internal void Fix_characters()
        {
            if (Title != null && Title.Contains("\n"))
            {
                Title.Replace("\n", "");
            }
            if (Snippet != null && Snippet.Contains("\n"))
            {
                Snippet.Replace("\n", "");
            }
            if (Source != null && Source.Contains("\n"))
            {
                Source.Replace("\n", "");
            }
            if (Link != null && Link.Contains("\n"))
            {
                Link.Replace("\n", "");
            }
        }
    }
}