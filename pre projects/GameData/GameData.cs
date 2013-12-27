using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GameData
{
    [Serializable]
    public class GameData : ResourceMapper
    {
        //TODO evaluate if this is sufficient or not...
        public List<Level> Levels { get; internal set; }

        public List<Puzzle> Puzzles { get; internal set; }

        public List<CutSceen> CutSceens { get; internal set; }

        public List<Dialog> Dialogs { get; internal set; }

        public List<string> Images { get; internal set; }

        public List<string> Videos { get; internal set; }

        public GameData(String DataPath)
        {
            if (!File.Exists(DataPath))
                throw new FileNotFoundException("GameData must be created with a valid GameData File, the Specified File could not be found", DataPath);

            //Load In Data via deserialize and copy to this instance
            this.CopyFrom(GameData.Load(DataPath));

            /*
             * Game Data needs to contain?
             *  - stored sepertely?
             * List of Problems
             * List of CutSceenes
             * List of Dialogs
             * List of Screens?
             * 
             * Heirachical list of 'Levels' and 'subLevels'?
             * 
             */
        }

        internal GameData()
        {
            this.Levels = new List<Level>();
            this.Puzzles = new List<Puzzle>();
            this.CutSceens = new List<CutSceen>();
            this.Dialogs = new List<Dialog>();
            this.Images = new List<string>();
            this.Videos = new List<string>();
        }

        public static GameData Load(String Path)
        {
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            if (!File.Exists(Path))
                throw new FileNotFoundException();
            Stream fs = File.OpenRead(Path);
            GameData gd = bf.Deserialize(fs) as GameData;
            //reload references
            gd.RootDirectory = System.IO.Path.GetDirectoryName(Path);
            for (int i = 0; i < gd.Images.Count; i++)
            {
                //Images are stored as file names only
                //getImage will convert this to %fileDirectory%/Images/%filename%
                gd.Images[i] = gd.getImage(gd.Images[i]);
            }
            for (int i = 0; i < gd.Videos.Count; i++)
            {
                //Videos are stored as file names only
                //getVideo will convert this to %fileDirectory%/Videos/%filename%
                gd.Videos[i] = gd.getVideo(gd.Videos[i]);
            }
            return gd;
        }

        internal void save(String path)
        {
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter BF = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Stream fs = File.Open(path, FileMode.OpenOrCreate);
            BF.Serialize(fs, this);
            fs.Flush();
            fs.Close();
        }
    }
}
