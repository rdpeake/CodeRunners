using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ctext = CodeRunners.Game.Text;

namespace CodeRunners.Game.Forms
{
    enum states {
        Sequence
    }

    public partial class HostForm : Form
    {
        #region Hide Close Button
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                System.Windows.Forms.CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CP_NOCLOSE_BUTTON;
                return cp;
            }
        }
        #endregion

        private Color DefaultTextColor { get { return Color.Black; } }
        private StringFormat defaultTextFormat
        {
            get
            {
                StringFormat textRenderFormat = new StringFormat();
                textRenderFormat.FormatFlags = StringFormatFlags.LineLimit;
                return textRenderFormat;
            }
        }
        private states state { get; set; }

        public HostForm()
        {
            InitializeComponent();

            loadChapter(GameState.getCurrentChapter(), false);

        }

        public void loadChapter(StoryLine.Chapter chapter, bool reset = true)
        {
            if (reset)
            {
                GameState.clearVariableScope("Story.CurrentChapter");
                GameState.currentGame["Story.CurrentChapter.Episode"] = 0;
                GameState.currentGame["Story.CurrentChapter.PlayedOpening"] = false;
                GameState.currentGame["Story.CurrentChapter.Level"] = 0;
            }

            if (!(bool)GameState.currentGame["Story.CurrentChapter.PlayedOpening"])
            {
                CurrentEpisodeIndex = 0;
                currentSequence = GameState.getCurrentChapter().OpeningSequence;
                loadEpisode(GameState.getCurrentChapter().OpeningSequence.interactions[0]);
            }
            else
            {
                //already played the opening, so load the current location
                loadLevels();
            }
        }

        public void loadEpisode(StoryLine.Episode episode)
        {
            this.state = states.Sequence;
            //TODO load resources!!!

            //get string
            this.renderString = ctext.processString(episode.DialogText);
            

            currentEpisode = episode;
            this.Invalidate();
        }


        protected void loadLevels()
        {

        }

        #region Interactions!!!!
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnClick(e);
            switch (this.state)
            {
                case states.Sequence:
                    SequenceOnMouseClick(e);
                    break;
            }
        }
        #endregion

        #region Paint and resize
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            //resize the font to keep a consistant render size for text :D
            SizeF stringsize = this.CreateGraphics().MeasureString(HostForm.SizeString, this.Font, this.ClientRectangle.Width, this.defaultTextFormat );

            float hRatio = (this.ClientRectangle.Height / 2.5f) / stringsize.Height;
            float wRatio = this.ClientRectangle.Width / stringsize.Width;
            float ratio = (hRatio > wRatio) ? hRatio : wRatio;

            float newSize = this.Font.Size * ratio;

            this.Font = new Font(this.Font.FontFamily, newSize, this.Font.Style);
            //this.renderString = SizeString;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Set clipping region.
            Rectangle clipRect = new Rectangle(0, 0, 200, 200);
            e.Graphics.SetClip(clipRect);

            // Update clipping region to intersection of 

            // existing region with specified rectangle.
            Rectangle intersectRect = new Rectangle(100, 100, 200, 200);
            e.Graphics.IntersectClip(intersectRect);

            // Fill rectangle to demonstrate effective clipping region.
            e.Graphics.FillRectangle(new SolidBrush(Color.Blue), 0, 0, 500, 500);

            // Reset clipping region to infinite.
            e.Graphics.ResetClip();

            // Draw clipRect and intersectRect to screen.
            e.Graphics.DrawRectangle(new Pen(Color.Black), clipRect);
            e.Graphics.DrawRectangle(new Pen(Color.Red), intersectRect);
            switch (state)
            {
                case states.Sequence:
                    SequenceOnPaint(e);
                    break;
            }
        }
        #endregion
    }
}
