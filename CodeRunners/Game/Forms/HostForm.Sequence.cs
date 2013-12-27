using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CodeRunners.Game.Forms
{
    partial class HostForm
    {
        struct RenderStrings
        {
            public string RenderString { get; set; }
            /// <summary>
            /// the position at the start of being displayed, relative to text window
            /// </summary>
            public Point StringStart { get; set; }
            /// <summary>
            /// width of text to render
            /// </summary>
            public int Width { get; set; }
            /// <summary>
            /// the colour of the text to render
            /// </summary>
            public Color StringColour { get; set; }
            /// <summary>
            /// render this string 
            /// </summary>
            /// <param name="g">graphics object to draw to</param>
            /// <param name="font">font to draw with</param>
            /// <param name="format"></param>
            /// <returns></returns>
            
            public bool Render(Graphics g, Font font, StringFormat format)
            {
                
                g.DrawString(RenderString, font, new SolidBrush(this.StringColour), new RectangleF(this.StringStart, new SizeF(this.Width, font.Height)), format);
                return true;
            }

            private static string LastString;
            private static int LastLineBreak;

            public static List<RenderStrings> getRenderObjects()
            {
                throw new NotImplementedException();
            }
        }

        //Sequence
        public static string SizeString = "WWWWWWWWWWWWWWWWWWW\n" +
                                  "WWWWWWWWWWWWWWWWWWW\n" +
                                  "WWWWWWWWWWWWWWWWWWW\n";
        public static int lineCount = 3;
        private Bitmap backgroundImage;
        private Bitmap characterImage;
        private string renderString;

        private StoryLine.Sequence currentSequence;
        private int CurrentEpisodeIndex;
        private StoryLine.Episode currentEpisode;

        public void SequenceOnPaint(PaintEventArgs e)
        {
            //show the 'dialog' sceen and add in the string stuff

            //draw the 'background and character in the top 2/3rds

            //draw the 'text box' in the bottom 1/3rd
            
            Rectangle textRectangle = new Rectangle(0, this.ClientRectangle.Height - (int)(this.ClientRectangle.Height / 2.5),
                this.ClientRectangle.Width, (int)(this.ClientRectangle.Height / 2.5));
            e.Graphics.IntersectClip(textRectangle);
            e.Graphics.Clear(Color.White);
            

            //TODO: change this to using the renderstrings object...

            //use a stack structure for the coloured words in case of nested colours!
            e.Graphics.DrawString(renderString, this.Font, new SolidBrush(this.DefaultTextColor), textRectangle, this.defaultTextFormat);

            if (currentEpisode.KeyType == StoryLine.EpisodeTypes.Response)
            {
                if (currentEpisode.responseType == StoryLine.EpisodeTypes.TextResponse)
                {
                    textBox1.Visible = true;
                }
                else
                {
                    List<string> responses = currentEpisode.ListResponses;
                    if (currentEpisode.responseType == StoryLine.EpisodeTypes.BooleanResponse)
                    {
                        responses = new List<string>() { "Yes", "No" };
                    }
                    //display responses

                }
            }

        }

        public void SequenceOnMouseClick(EventArgs e)
        {
            switch (currentEpisode.KeyType)
            {
                case StoryLine.EpisodeTypes.Dialog:
                case StoryLine.EpisodeTypes.Video:
                    CurrentEpisodeIndex++;
                    break;
                case StoryLine.EpisodeTypes.Response:
                    switch (currentEpisode.responseType)
                    {

                    }
                    break;
            }
            if (CurrentEpisodeIndex < currentSequence.interactions.Count)
                loadEpisode(currentSequence.interactions[CurrentEpisodeIndex]);
            else
                //load next thing :P
                if (currentSequence == GameState.getCurrentChapter().OpeningSequence)
                {
                    loadLevels();
                }
                else
                {
                    GameState.currentGame["Story.CurrentChapter"] = GameState.getCurrentChapter().NextChapter();
                }
        }

        public void SequenceOnKeyPress(KeyPressEventArgs e)
        {

        }


    }
}
