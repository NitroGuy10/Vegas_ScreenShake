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
        public static GUI gui;

        public static List<PictureInPicture> NewPictureInPictures
        {
            // Create a new PictureInPicture object for every selected clip
            get
            {
                List<PictureInPicture> list = new List<PictureInPicture>();
                foreach (Track track in vegas.Project.Tracks)
                {
                    foreach (TrackEvent trackEvent in track.Events)
                    {
                        if (trackEvent.Selected && trackEvent.MediaType == MediaType.Video)
                        {
                            list.Add(new PictureInPicture((VideoEvent)trackEvent));
                        }
                    }
                }
                return list;
            }
        }
    }
}
