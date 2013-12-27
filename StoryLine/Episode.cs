using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryLine
{
    public delegate int DialogOffsetDelegate(string response);
    public enum EpisodeTypes
    {
        //key types
        Video = 1,
        Dialog = 2,
        Response = 4,

        //reponse types
        BooleanResponse = 256,
        TextResponse = 512,
        ListResponse = 1024
    }
    public class Episode : MarshalByRefObject
    {
        /// <summary>
        /// Contains details about the type of episode
        /// </summary>
        public EpisodeTypes EpisodeType { get; protected set; }
        /// <summary>
        /// gets the key type -> Video, Dialog, Response: masks with 0xff
        /// </summary>
        public EpisodeTypes KeyType { get { return (EpisodeTypes)((int)EpisodeType & 0xff); } }
        /// <summary>
        /// gets the type of reponse, minus the key responses: masks the type with 0xff00
        /// </summary>
        public EpisodeTypes responseType { get { return (EpisodeTypes)((int)EpisodeType & 0xff00); } }
        /// <summary>
        /// the location or other identifier of the video to display
        /// </summary>
        public string VideoSource { get; protected set; }
        /// <summary>
        /// the text to display for this bit of the dialog sequence: is processed by the language,variable, colour directives.
        /// </summary>
        public string DialogText { get; protected set; }
        /// <summary>
        /// source or other identifier for the background image
        /// </summary>
        public string DialogBackground { get; protected set; }
        /// <summary>
        /// source or other identifier (eg: {player} ) for the character image
        /// </summary>
        public string DialogCharacter { get; protected set; }
        /// <summary>
        /// if used... a source or other directive for audio
        /// </summary>
        public string DialogAudio { get; protected set; }
        /// <summary>
        /// the list of responses for the listresponse type
        /// </summary>
        public List<string> ListResponses { get; protected set; }
        /// <summary>
        /// a string to show as a default response.
        /// </summary>
        public string DefaultTextResponse { get; protected set; }
        /// <summary>
        /// variable to put the response into
        /// </summary>
        public string VariableForResponse { get; protected set; }
        /// <summary>
        /// a method which takes is pased the response for this episode if it a response type and the return value is used to alter location in the sequence of dialog
        /// 
        /// allows for branching cutsceens based on user response.
        /// </summary>
        public DialogOffsetDelegate DialogOffset { get; protected set; }
        public Episode(EpisodeTypes episodeType, string dialogText = "", string dialogBackground = "", string dialogCharacter = "", string dialogAudio = "",
             List<string> listResponses = null, string defaultTextResponse = "", string variableForResponse = "dialog.response", string videoSource = "",
            DialogOffsetDelegate dialogOffset = null)
        {
            this.EpisodeType = episodeType;
            this.DialogText = dialogText;
            this.DialogBackground = dialogBackground;
            this.DialogCharacter = dialogCharacter;
            this.DialogAudio = dialogAudio;
            this.ListResponses = listResponses ?? new List<string>();
            this.DefaultTextResponse = defaultTextResponse;
            this.VariableForResponse = variableForResponse;
            this.VideoSource = videoSource;
            this.DialogOffset = dialogOffset ?? new DialogOffsetDelegate((s) => { return 1; });
        }
    }
}
