using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryLine
{
    /// <summary>
    /// contains the details for showing either a video, dialog or other cutsceen like sequence (includeing multiple sequences and detail retreaval.
    /// </summary>
    public class Sequence : MarshalByRefObject
    {
        public Sequence()
        {
            interactions = new List<Episode>();
        }

        public List<Episode> interactions { get; protected set; }
    }
}
