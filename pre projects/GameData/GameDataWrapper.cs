using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData
{
    public class ResourceMapper
    {
        protected string RootDirectory { get; set; }

        protected string getVideo(string Path)
        {
            if (System.IO.Path.IsPathRooted(Path))
            {
                return System.IO.Path.GetFullPath(Path);
            }
            else if (!String.IsNullOrEmpty(RootDirectory))
            {
                return System.IO.Path.Combine(RootDirectory, "Video", Path);
            }
            else
                throw new InvalidOperationException("RootDirectory is not set and a 'Relational' file was specified");
        }

        protected string getImage(string Path)
        {
            if (System.IO.Path.IsPathRooted(Path))
            {
                return System.IO.Path.GetFullPath(Path);
            }
            else if (!String.IsNullOrEmpty(RootDirectory))
            {
                return System.IO.Path.Combine(RootDirectory, "Image", Path);
            }
            else
                throw new InvalidOperationException("RootDirectory is not set and a 'Relational' file was specified");
        }
    }

    class GameDataWrapper : ResourceMapper
    {
        private GameData data { get; set; }
        public GameDataWrapper(GameData BaseObject = null)
        {
            data = BaseObject;
            if (data == null)
                data = new GameData();
        }

        public List<Level> Levels
        {
            get
            {
                return data.Levels;
            }
            set
            {
                data.Levels = value;
            }
        }

        public List<Puzzle> Puzzles
        {
            get
            {
                return data.Puzzles;
            }
            set
            {
                data.Puzzles = value;
            }
        }

        public List<CutSceen> CutSceens
        {
            get
            {
                return data.CutSceens;
            }
            set
            {
                data.CutSceens = value;
            }
        }

        public List<Dialog> Dialogs
        {
            get
            {
                return data.Dialogs;
            }
            set
            {
                data.Dialogs = value;
            }
        }

        public List<string> Images
        {
            get
            {
                return data.Images;
            }
            set
            {
                data.Images = value;
            }
        }

        public List<string> Videos
        {
            get
            {
                return data.Videos;
            }
            set
            {
                data.Videos = value;
            }
        }

        public void Save(string Directory, bool SupressWarnings = false)
        {
            //TODO save data and translate Images and Videos list to relative paths (for all those not already)
            if (System.IO.Directory.Exists(Directory))
            {
                System.IO.Directory.CreateDirectory(Directory);
            }
            this.RootDirectory = Directory;
            Microsoft.VisualBasic.Devices.Computer computer = new Microsoft.VisualBasic.Devices.Computer();
            this.data.save(System.IO.Path.Combine(Directory, "Data.gdf"));
            for (int i = 0; i < Images.Count; i++ )
            {
                //check if file already copied
                string fileName = System.IO.Path.GetFileName(Images[i]);

                if (this.getImage(Images[i]) != this.getImage(fileName))
                {
                    //copy file
                    if (!System.IO.File.Exists(getImage(fileName)) || SupressWarnings)
                        System.IO.File.Copy(this.getImage(Images[i]), this.getImage(fileName), true);
                    else
                        computer.FileSystem.CopyFile(this.getImage(Images[i]), this.getImage(fileName), Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.ThrowException); 
                }

                this.Images[i] = fileName;
            }

            for (int i = 0; i < Videos.Count; i++)
            {
                string fileName = System.IO.Path.GetFileName(Videos[i]);

                if (this.getVideo(Videos[i]) != this.getVideo(fileName))
                {
                    //copy file
                    if (!System.IO.File.Exists(getVideo(fileName)) || SupressWarnings)
                        System.IO.File.Copy(this.getVideo(Videos[i]), this.getVideo(fileName), true);
                    else
                        computer.FileSystem.CopyFile(this.getVideo(Videos[i]), this.getVideo(fileName), Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.ThrowException);
                }

                this.Videos[i] = fileName;
            }
        }

        public static void Load(string Directory)
        {
            if (!System.IO.Directory.Exists(Directory))
            {
                throw new System.IO.DirectoryNotFoundException("Could not find the specified Directory");
            }
            //TODO Load data
            GameDataWrapper gdw = new GameDataWrapper();
            gdw.RootDirectory = Directory;
            gdw.data = GameData.Load(System.IO.Path.Combine(Directory, "Data.gdf"));
        }

    }
}
