using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace RingTest
{
    public class PlaySoundClass
    {
        ISimpleAudioPlayer soundBreath = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
        ISimpleAudioPlayer soundHold = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;

        public PlaySoundClass()
        {
            try
            {
                Stream stream;
                stream = GetDeviceInfo.GetStream("Sound", "Kalimba.mp3");
                soundBreath.Load(stream);
            }
            catch (Exception ex)
            {

            }
   
        }

        public void PlaySound()
        {
            soundBreath.Play();
        }
        public void StopSound()
        {
            soundHold.Play();
        }
    }

    public static class GetDeviceInfo
    {
        public static Stream GetStream(string FolderName, string fileName)
        {
            TypeInfo pageInfo = typeof(GetDeviceInfo).GetTypeInfo();
            Assembly assembly = pageInfo.Assembly;
            string[] resourceNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            Stream abc = assembly.GetManifestResourceStream($"{resourceNames[0]}");
            return abc;
        } 
    }
}
