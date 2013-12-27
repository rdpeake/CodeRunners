using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConditonalControl;

namespace StoryLine
{
    public delegate int NexthChapterDelegate();
    /// <summary>
    /// each chapter will hold
    ///     an opening cutsceene
    ///     A list of sceenes
    ///         using conditions to amend these for more diverse gameplay
    ///     Conditions needed to complete level
    ///         possible rewards
    ///     A closing Cutsceene
    /// </summary>
    public class Chapter : MarshalByRefObject
    {
        //hold section stuff...

        /*
         * a chapter will consist of:
         *      Opening sequence(s)
         *      
         *      Level List
         *      
         *      Non-locational condition for starting end sequence (otherwise it is built into the level list)
         *      
         *      end sequence(s)
         * 
         */

        public Chapter()
        {
            OpeningSequence = new Sequence();

        }

        public Sequence OpeningSequence { get; protected set; }

        public object Screens { get; set; }

        public Condition endConditions { get; set; }

        public Boolean isEnded()
        {
            return endConditions.isMet();
        }

        public Sequence ClosingSequence { get; set; }

        public NexthChapterDelegate NextChapter { get; set; }
    }
}
