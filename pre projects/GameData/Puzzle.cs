using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData
{
    [Serializable]
    public class Puzzle
    {
        const string PuzzleMultiChoice = "Puzzle.MutliChoice";
        const string PuzzleShortAnswer = "Puzzle.ShortAnswer";
        const string PuzzleCode = "Puzzle.Code";

        const string CodeLinea = "Code.Linea";
        const string CodeInterrupt = "Code.Interrupt";
        //core languages
        const string LanguageCsharp = "Language.CSharp";
        const string LanguageJava = "Language.Java";
        const string LanguageVBNet = "Language.VB.Net";
        const string LanguagePython = "Language.Python";
        //default
        const string LanguageNone = "Language.None";
        //Early Game
        const string LanguageAssem = "Language.Assembly";
        const string LanguageCustom = "Language.Custom";
        //potential
        /*
        const string LanguageVBA = "Language.VB.Applications";
        const string LanguageJavaScript = "Language.JavaScritp";
        const string LanguageCPlusPlus = "Language.C++";
        */

        public string PuzzleType { get; set; }
        public string PuzzleCodeType { get; set; }
        public string LanguageDependancy {get; set;}
        /// <summary>
        /// Used to determin what 'features' are required for device
        /// </summary>
        public string HardwareLevel { get; set; }
        /// <summary>
        /// Used to limit the hardware to the required level only even if actual hardware is better
        /// </summary>
        public bool LimitHadware { get; set; }
        public string Description { get; set; }
        public string ShortAnswer { get; set; }
        public List<string> MultiAnswers { get; set; }
        public string CompletionReward { get; set; }


        //TODO work out how to Include Programming Problems
    }
}
