using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldControls
{
    public partial class Dialog: UserControl
    {
        public bool complete { get; private set; }

        //TODO consider changing this to an event!!!
        private bool _interactionComplete = false;
        /// <summary>
        /// returns if the interaction was complete and unsets the value upon retreval
        /// </summary>
        public bool interactionComplete
        {
            get
            {
                bool temp = _interactionComplete;
                if (_interactionComplete == true)
                {
                    _interactionComplete = false;
                }
                return temp;
            }
            private set
            {
                if (_interactionComplete != value)
                {
                    _interactionComplete = value;
                }
            }
        }
        public string returnValue { get; private set; }
        public string returnProperty { get; set; }

        private GameData.Dialog internalDialog { get; set; }
        [DefaultValue(true)]
        public bool Animate { get; set; }

        private int _interactionPosition = -1;
        private int interactionPosition
        {
            get
            {
                return _interactionPosition;
            }
            set
            {
                if (_interactionPosition != value)
                {
                    _interactionPosition = value;
                    //reset the line position to the start;
                    _linePosition = -1;
                    if (internalDialog.Interactions[value].Lines.Count > 0)
                    {
                        
                        linePosition = 0;
                    }
                }
            }
        }

        private int _linePosition = -1;
        private int linePosition
        {
            get
            {
                return _linePosition;
            }
            set
            {
                if (_linePosition != value)
                {
                    _linePosition = value;
                    if (Animate)
                        animating = true;
                    else
                    {
                        setCompleteText();
                    }
                }
            }
        }


        private int animatingPosition { get; set; }

        private Timer animateTimer;
        private bool animating
        {
            get
            {
                return animateTimer.Enabled;
            }
            set
            {
                if (value != animateTimer.Enabled)
                {
                    if (!value)
                    {
                        //to simplify skip animating ensure all text is displayed on disable of timer
                        setCompleteText();
                    }
                    else
                    {
                        animatingPosition = 1;
                    }
                    animateTimer.Enabled = value;
                }
            }
        }

        private void setCompleteText()
        {
            DialogText.Text = getLine(linePosition);
            if (linePosition < internalDialog.Interactions[interactionPosition].Lines.Count - 1)
            {
                DialogText.Text += "\n" + getLine(linePosition + 1);
            }
        }

        public Dialog()
        {
            this.Animate = true;
            InitializeComponent();
            setSize();
            animateTimer = new Timer();
            animateTimer.Interval = 100;
            animateTimer.Tick += animateTimer_Tick;

            this.Click += Dialog_Click;
        }

        void Dialog_Click(object sender, EventArgs e)
        {
            if (complete)
                return;
            if (animating)
                animating = false;
            else
            {
                if (linePosition >= internalDialog.Interactions[interactionPosition].Lines.Count - 2)
                {
                    //check last transition
                    if (true /*last transition pass*/)
                    {
                        //if has return val set it
                        this.returnValue = "";
                        this.returnProperty = internalDialog.Interactions[interactionPosition].ResponseProperty;
                        this.interactionComplete = true;
                        //check for more interactions
                        if (interactionPosition < internalDialog.Interactions.Count - 1)
                        {
                            interactionPosition++;
                        }
                        else
                        {
                            complete = true;
                        }
                    }
                }
                else
                    linePosition += 2;
            }
        }

        public string getLine(int line)
        {
            if (internalDialog.Interactions[interactionPosition].Lines.Count > 0 && internalDialog.Interactions[interactionPosition].Lines.Count > line)
                return internalDialog.Interactions[interactionPosition].Lines[line];
            return "";
        }

        void animateTimer_Tick(object sender, EventArgs e)
        {
            //update animate timer;
            int string_total = getLine(linePosition).Length;
            if (linePosition < internalDialog.Interactions[interactionPosition].Lines.Count - 1)
            {
                string_total += getLine(linePosition + 1).Length;
            }

            if (animatingPosition >= string_total)
            {
                animating = false;
                return;
            }

            DialogText.Text = getLine(linePosition).Substring(0, (int)Math.Min(animatingPosition, getLine(linePosition).Length));

            if (animatingPosition >= getLine(linePosition).Length)
            {
                DialogText.Text += "\n" + getLine(linePosition + 1).Substring(0, animatingPosition - getLine(linePosition).Length);
            }

            animatingPosition += 1;
        }

        private void setSize()
        {
            this.Font = new Font(this.Font.FontFamily, (this.Height/this.MinimumSize.Height) * 8.5f, FontStyle.Regular);
            DialogText.Font = this.Font;
            textBox1.Font = this.Font;
            textBox1.Height = this.Font.Height;
            textBox1.Top = this.Height / 2 - textBox1.Height / 2;
            DialogText.Height = this.Height / 4;
        }

        private void Dialog_SizeChanged(object sender, EventArgs e)
        {
            setSize();
        }

        public void setDialog(GameData.Dialog dialog)
        {
            this.internalDialog = dialog;
            complete = false;
            _interactionPosition = -1;
            if (dialog.Interactions.Count > 0)
                this.interactionPosition = 0;
        }
    }
}
