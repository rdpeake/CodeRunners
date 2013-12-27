using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryLine
{
    class Chapter1 : Chapter
    {
        public Chapter1()
        {
            //opening sequence----------------------------------------------------
            OpeningSequence = new Sequence();

            Episode chapter1OpeningEpisode1 = new Episode(EpisodeTypes.Dialog, "{$dialog.Chapter1OpeningEpisode1}", "ownerbackground", "owner");

            OpeningSequence.interactions.Add(chapter1OpeningEpisode1);

            Episode chapter1OpeningEpisode2 = new Episode(EpisodeTypes.Response | EpisodeTypes.ListResponse, "{$dialog.Chapter1OpeningEpisode2}",
                "ownerbackground", "owner",listResponses: new List<string>() { "Male", "Female" }, variableForResponse: "player.gender");

            OpeningSequence.interactions.Add(chapter1OpeningEpisode2);

            Episode chapter1OpeningEpisode3 = new Episode(EpisodeTypes.Response | EpisodeTypes.BooleanResponse, "{$dialog.Chapter1OpeningEpisode3}",
                "ownerbackground", "owner", dialogOffset: new DialogOffsetDelegate((response) =>
                {
                    if (response == false.ToString())
                        return -1;
                    return 1;
                })
            );

            OpeningSequence.interactions.Add(chapter1OpeningEpisode3);
            
            Episode chapter1OpeningEpisode4 = new Episode(EpisodeTypes.Response | EpisodeTypes.TextResponse, "{$dialog.Chapter1OpeningEpisode4}",
                "ownerbackground", "owner", variableForResponse: "player.name", defaultTextResponse: "Name");

            OpeningSequence.interactions.Add(chapter1OpeningEpisode4);

            Episode chapter1OpeningEpisode5 = new Episode(EpisodeTypes.Response | EpisodeTypes.BooleanResponse, "{$dialog.Chapter1OpeningEpisode5}",
                    "ownerbackground", "owner", dialogOffset: new DialogOffsetDelegate((response) =>
            {
                if (response == false.ToString())
                    return -1;
                return 1;
            })
            );
            OpeningSequence.interactions.Add(chapter1OpeningEpisode5);

            Episode chapter1OpeningEpisode6 = new Episode(EpisodeTypes.Dialog, "{$Chapter1OpeningEpisode6}",  "ownerbackground", "owner");

            OpeningSequence.interactions.Add(chapter1OpeningEpisode6);



            //Levels-------------------------------------------------------------




            //Closing coditions--------------------------------------------------

            //closing sequence----------------------------------------------------

            //next chapter------------------------------------------------------
            this.NextChapter = () => { return 2; };
        }
    }
}
