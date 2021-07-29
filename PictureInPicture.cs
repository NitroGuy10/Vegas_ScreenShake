using System;
using System.Linq;
using ScriptPortal.Vegas;

namespace ScreenShake
{
    public class PictureInPicture
    {
        public VideoEvent VideoEvent;
        public OFXEffect OFXEffect;

        public OFXDouble2DParameter location;

        public PictureInPicture(VideoEvent videoEvent)
        {
            VideoEvent = videoEvent;
            VideoEvent.Effects.AddEffect(VegasH.vegas.VideoFX.GetChildByName("VEGAS Picture In Picture"));
            OFXEffect = videoEvent.Effects[videoEvent.Effects.Count - 1].OFXEffect;

            location = (OFXDouble2DParameter)OFXEffect.FindParameterByName("Location");
        }

        public void MakeLocationKeyframe (double x, double y)
        {
            // TODO but actually make a keyframe instead of just changing the parameter value
            OFXDouble2D newLocation = new OFXDouble2D();
            newLocation.X = x;
            newLocation.Y = y;
            location.Value = newLocation;
            location.ParameterChanged();
        }
    }
}
