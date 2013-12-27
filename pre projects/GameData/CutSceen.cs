using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData
{
    /// <summary>
    /// Cutsceen consits of either a video or DialogSequence
    /// </summary>
    [Serializable]
    public class CutSceen
    {
        public List<int> Video { get; set; }
        public List<int> BackImage { get; set; }
        public List<int> Dialog { get; set; }

    }
}
