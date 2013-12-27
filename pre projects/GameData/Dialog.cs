using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData
{
    [Serializable]
    public class Dialog
    {
        public enum FinalTransitionTypes
        {
            AnyKey,
            OptionsList,
            TextInput
        }

        public Dialog()
        {
            this.Interactions = new List<Interaction>();
        }

        /// <summary>
        /// used to help in developement
        /// </summary>
        public string Name { get; set; }
        //maybe combine this into interactions?
        public List<Interaction> Interactions { get; set; }

        public class Interaction
        {
            public Interaction()
            {
                this.Lines = new List<string>();
                this.CharacterImage = -1;
            }
            public int CharacterImage { get; set; }
            public bool isPlayer { get; set; }
            public List<string> Lines { get; set; }
            public FinalTransitionTypes FinalTransitionType { get; set; }
            public string ResponseProperty { get; set; }
            public List<string> OptionsList { get; set; }

            public override string ToString()
            {
                return "Interaction";
                //return base.ToString();
            }
        }
    }
}
