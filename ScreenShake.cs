using System;
using System.Collections.Generic;
using ScriptPortal.Vegas;
using System.Windows.Forms;

namespace ScreenShake
{
    static class ScreenShake
    {
        public static void Apply()
        {
            // Parameters
            string seed = VegasH.gui.Seed;  // 0 for random
            double rotationSpeed = SettingControl.SettingControls["Rotation Speed"].Value;
            double rotationIntensity = SettingControl.SettingControls["Rotation Intensity"].Value;
            double shakeSpeed = SettingControl.SettingControls["Shake Speed"].Value;
            double shakeIntensity = SettingControl.SettingControls["Shake Intensity"].Value;

            double offsetPosX;
            double offsetPosY;

            double rotation;
            
            foreach (PictureInPicture pip in VegasH.NewPictureInPictures)
            {
                FastNoiseLite noise;
                if (seed.Equals("0"))
                {
                    noise = new FastNoiseLite(((new Random()).Next() * 199) + 1);
                }
                else
                {
                    noise = new FastNoiseLite(seed.GetHashCode());
                }
                noise.SetNoiseType(FastNoiseLite.NoiseType.Perlin);

                for (int frame = 0; frame < pip.VideoEvent.Length.FrameCount /* or some more relevant value */; frame++)
                {
                    rotation = Math.Sin(frame * rotationSpeed) * (Math.PI * rotationIntensity);
                    rotation *= 180 / Math.PI;
                    offsetPosX = noise.GetNoise((float)(frame * shakeSpeed), 0) * shakeIntensity;
                    offsetPosY = noise.GetNoise(0, (float)(frame * shakeSpeed)) * shakeIntensity;

                    pip.MakeLocationKeyframe(0.5 + offsetPosX, 0.5 + offsetPosY, Timecode.FromFrames(pip.VideoEvent.Start.FrameCount + frame));
                    pip.MakeAngleKeyframe(rotation, Timecode.FromFrames(pip.VideoEvent.Start.FrameCount + frame));
                }
            }          

        }
    }
}
