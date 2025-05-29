using NAudio.Wave;
using NAudio.Dsp;

namespace Proyecto1
{
    
    public class AudioAnalyzer : IDisposable
    {
        private WaveOutEvent outputDevice;
        private WaveStream audioFile;
        private float[] fftBuffer;
        private int fftPos;
        private int fftLength = 1024;
        private Complex[] fftComplex;
        private float[] lastMagnitudes;

        public bool IsPlaying => outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing;

        public AudioAnalyzer()
        {
            fftBuffer = new float[fftLength];
            fftComplex = new Complex[fftLength];
            lastMagnitudes = new float[60];
        }

        public void Load(string filePath)
        {
            Dispose();

            if (filePath.EndsWith(".mp3", StringComparison.OrdinalIgnoreCase))
            {
                var reader = new Mp3FileReader(filePath);
                audioFile = new WaveChannel32(reader); 
            }
            else if (filePath.EndsWith(".wav", StringComparison.OrdinalIgnoreCase))
            {
                var reader = new WaveFileReader(filePath);
                audioFile = new WaveChannel32(reader);
            }
            else
            {
                throw new NotSupportedException("Solo se soportan archivos .mp3 o .wav");
            }

            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);
        }



        public void Play()
        {
            outputDevice?.Play();
        }

        public void Pause()
        {
            outputDevice?.Pause();
        }

        public void Stop()
        {
            outputDevice?.Stop();
            if (audioFile != null)
                audioFile.Position = 0;
        }

        
        public float[] GetAmplitudes(int bands = 60)
        {
            if (audioFile == null || audioFile.Position >= audioFile.Length)
                return lastMagnitudes;

            int bytesPerSample = 4; 
            int byteBufferSize = fftLength * bytesPerSample;
            byte[] byteBuffer = new byte[byteBufferSize];

            int bytesRead = audioFile.Read(byteBuffer, 0, byteBufferSize);
            int samplesRead = bytesRead / bytesPerSample;

            for (int i = 0; i < fftLength; i++)
            {
                float sample = 0;
                if (i < samplesRead)
                {
                    sample = BitConverter.ToSingle(byteBuffer, i * bytesPerSample);
                    fftComplex[i].X = sample * (float)FastFourierTransform.HammingWindow(i, fftLength);
                }
                else
                {
                    fftComplex[i].X = 0;
                }
                fftComplex[i].Y = 0;
            }

            FastFourierTransform.FFT(true, (int)Math.Log(fftLength, 2.0), fftComplex);

            float[] magnitudes = new float[bands];
            int bandWidth = fftLength / 2 / bands;

            for (int i = 0; i < bands; i++)
            {
                float sum = 0;
                for (int j = 0; j < bandWidth; j++)
                {
                    int index = i * bandWidth + j;
                    if (index < fftLength / 2)
                    {
                        float re = fftComplex[index].X;
                        float im = fftComplex[index].Y;
                        sum += (float)Math.Sqrt(re * re + im * im);
                    }
                }
                magnitudes[i] = sum / bandWidth;
            }

            lastMagnitudes = magnitudes;
            return magnitudes;
        }



        public void Dispose()
        {
            outputDevice?.Dispose();
            audioFile?.Dispose();
            outputDevice = null;
            audioFile = null;
        }

    }
}

