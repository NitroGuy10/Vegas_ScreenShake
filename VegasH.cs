using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScriptPortal.Vegas;

namespace ScreenShake
{
    public static class VegasH
    {
        public static Vegas vegas;
        private static Dictionary<VideoEvent, PictureInPicture> pictureInPictures = new Dictionary<VideoEvent, PictureInPicture>();

        public static bool appliedAnimation = false;

        public static List<PictureInPicture> PictureInPictures
        {
            // Get the PictureInPicture object for every selected clip
            // If a clip does not have one, create it
            get
            {
                List<PictureInPicture> list = new List<PictureInPicture>();
                foreach (Track track in vegas.Project.Tracks)
                {
                    foreach (TrackEvent trackEvent in track.Events)
                    {
                        if (trackEvent.Selected && trackEvent.MediaType == MediaType.Video)
                        {
                            VideoEvent videoEvent = (VideoEvent)trackEvent;
                            if (!pictureInPictures.ContainsKey(videoEvent))
                            {
                                pictureInPictures[videoEvent] = new PictureInPicture(videoEvent);
                            }
                            list.Add(pictureInPictures[videoEvent]);
                        }
                    }
                }
                return list;
            }
        }
    }
}
