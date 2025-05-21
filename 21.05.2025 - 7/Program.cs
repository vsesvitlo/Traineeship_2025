/*7. Створи інтерфейс IPlayable з методами Play() і Pause().
Реалізуй його в класах VideoPlayer і MusicPlayer.
*/
namespace _21._05._2025___7
{
    internal class Program
    {
        interface IPlayable
        {
            void Play();
            void Pause();
        }
        class VideoPlayer : IPlayable
        {

            void IPlayable.Play()
            {
                Console.WriteLine("Video player plays");
            }
            void IPlayable.Pause()
            {
                Console.WriteLine("Video player pauses");
            }

            public void Play()
            {
                IPlayable play = new VideoPlayer();
                play.Play();
            }
            public void Pause()
            {
                IPlayable pause = new VideoPlayer();
                pause.Pause();
            }
        }
        class MusicPlayer : IPlayable
        {

            void IPlayable.Play()
            {
                Console.WriteLine("Music player plays");
            }
            void IPlayable.Pause()
            {
                Console.WriteLine("Music player pauses");
            }

            public void Play()
            {
                MusicPlayer play = new MusicPlayer();
                play.Play();
            }
            public void Pause()
            {
                IPlayable pause = new MusicPlayer();
                pause.Pause();
            }
        }
        static void Main(string[] args)
        {
            IPlayable video = new VideoPlayer();
            video.Play();
            video.Pause();
            IPlayable music = new MusicPlayer();
            music.Play();
            music.Pause();
        }
    }
}
