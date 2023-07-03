using AudioSwitcher.AudioApi.CoreAudio;
using System;

namespace WinVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            CoreAudioController coreAudioController = new CoreAudioController();
            CoreAudioDevice defaultPlaybackDevice = coreAudioController.DefaultPlaybackDevice;

            double volume = defaultPlaybackDevice.Volume;
            if (args.Length > 0)
            {
                if (double.TryParse(args[0], out volume))
                {
                    defaultPlaybackDevice.Volume = volume;
                }
                else
                {
                    Console.WriteLine("Invalid value");
                }
            }
            else
            {
                Console.WriteLine(volume);
            }
        }
    }
}
