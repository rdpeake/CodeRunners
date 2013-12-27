using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryLine
{
    public class Story : MarshalByRefObject
    {
        protected List<Chapter> Chapters = new List<Chapter>();

        public Chapter this[int index]
        {
            get
            {
                if (index > -1 && index < Chapters.Count)
                {
                    return Chapters[index];
                }
                throw new IndexOutOfRangeException();
            }
        }

        public virtual List<string> getLang()
        {
            return new List<string>();
        }
    }
}
