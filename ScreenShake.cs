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
            double shakeSpeed = SettingControl.SettingControls["Shake Speed"].Value;  // good range: 0.6 - ???
            double shakeIntensity = 1;  // previously 200
            double roughness = 0.01;  // Determines lerp amount, scale of 0-1

            // The x and y of the Picture In Picture effect for a given keyframe is (0.5 + offsetPosX, 0.5 + offsetPosY)
            double offsetPosX = 0;
            double offsetPosY = 0;

            double rotation;

            // These are used for animation smoothing
            double nextPosX;
            double nextPosY;
            
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
                    nextPosX = noise.GetNoise((float)(frame * shakeSpeed), 0) * shakeIntensity;
                    nextPosY = noise.GetNoise(0, (float)(frame * shakeSpeed)) * shakeIntensity;
                    offsetPosX = Lerp(offsetPosX, nextPosX, roughness);
                    offsetPosY = Lerp(offsetPosY, nextPosY, roughness);

                    pip.MakeLocationKeyframe(0.5 + offsetPosX, 0.5 + offsetPosY, Timecode.FromFrames(pip.VideoEvent.Start.FrameCount + frame));
                    Console.WriteLine(string.Format("({0}, {1}) - {2}", offsetPosX, offsetPosY, rotation));
                }
            }          

        }

        static double Lerp(double position, double destination, double by)
        {
            return position * (1 - by) + destination * by;
        }
    }
}
