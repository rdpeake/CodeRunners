using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryLine
{
    public class StoryLine : Story
    {
        public StoryLine()
        {
            //populate the Chapters List
            Chapter chapter1 = new Chapter1();

            Chapters.Add(chapter1);
            
        }

        public override List<string> getLang()
        {
            return new List<string>() {
                "dialog", "puzzle"
            };
        }
    }
}
