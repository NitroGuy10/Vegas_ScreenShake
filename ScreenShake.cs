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
            Console.WriteLine("Hello, ScreenShake!");

            // Parameters
            int seed = 0; // 0 for random
            double rotationSpeed = 0.15;  // Higher value == slower speed
            double rotationIntensity = 0.008;
            double shakeSpeed = SettingControl.SettingControls["Shake Speed"].Value;  // good range: 0.6 - 60
            double shakeIntensity = SettingControl.SettingControls["Shake Intensity"].Value;  // good range: ??? - 1

            // The x and y of the Picture In Picture effect for a given keyframe is (0.5 + offsetPosX, 0.5 + offsetPosY)
            double offsetPosX;
            double offsetPosY;

            double rotation;
            
            foreach (PictureInPicture pip in VegasH.NewPictureInPictures)
            {
                if (seed == 0)
                {
                    seed = ((new Random()).Next() * 199) + 1;
                }

                FastNoiseLite noise = new FastNoiseLite(seed);
                noise.SetNoiseType(FastNoiseLite.NoiseType.Perlin);

                for (int frame = 0; frame < pip.VideoEvent.Length.FrameCount /* or some more relevant value */; frame++)
                {
                    rotation = Math.Sin(frame * rotationSpeed) * (Math.PI * rotationIntensity);
                    rotation *= 180 / Math.PI;
                    offsetPosX = noise.GetNoise((float)(frame * shakeSpeed), 0) * shakeIntensity;
                    offsetPosY = noise.GetNoise(0, (float)(frame * shakeSpeed)) * shakeIntensity;

                    pip.MakeLocationKeyframe(0.5 + offsetPosX, 0.5 + offsetPosY, Timecode.FromFrames(pip.VideoEvent.Start.FrameCount + frame));
                }
            }          

        }
    }
}
