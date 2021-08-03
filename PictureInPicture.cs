using System;
using System.Linq;
using ScriptPortal.Vegas;
using System.Windows.Forms;

namespace ScreenShake
{
    public class PictureInPicture
    {
        public VideoEvent VideoEvent;
        public Effect Effect;

        public OFXDouble2DParameter location;
        public OFXDoubleParameter angle;

        public PictureInPicture(VideoEvent videoEvent)
        {
            VideoEvent = videoEvent;
            VideoEvent.Effects.AddEffect(VegasH.vegas.VideoFX.GetChildByName("VEGAS Picture In Picture"));
            Effect = videoEvent.Effects[videoEvent.Effects.Count - 1];

            location = (OFXDouble2DParameter)OFXEffect.FindParameterByName("Location");
            angle = (OFXDoubleParameter)OFXEffect.FindParameterByName("Angle");

            OFXDoubleParameter scale = (OFXDoubleParameter)OFXEffect.FindParameterByName("Scale");
            scale.Value = 1;
            scale.ParameterChanged();
        }

        public OFXEffect OFXEffect
        {
            get
            {
                return Effect.OFXEffect;
            }
        }

        public void MakeLocationKeyframe (double x, double y, Timecode time)
        {
            OFXDouble2D newLocation = new OFXDouble2D();
            newLocation.X = x;
            newLocation.Y = y;

            location.SetValueAtTime(time, newLocation);
            location.ParameterChanged();
        }

        public void MakeAngleKeyframe(double rotation, Timecode time)
        {
            angle.SetValueAtTime(time, rotation);
            angle.ParameterChanged();
        }
    }
}
