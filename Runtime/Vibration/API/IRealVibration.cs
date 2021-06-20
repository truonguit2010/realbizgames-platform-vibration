
namespace RealbizGames.Platform
{
    public interface IRealVibration
    {
        void Init();

        ///<summary>
        /// Tiny pop vibration
        ///</summary>
        void VibratePop();

        ///<summary>
        /// Small peek vibration
        ///</summary>
        void VibratePeek();

        ///<summary>
        /// 3 small vibrations
        ///</summary>
        void VibrateNope();

        ///<summary>
        /// Only on Android
        /// https://developer.android.com/reference/android/os/Vibrator.html#vibrate(long)
        ///</summary>
        void Vibrate(long milliseconds);

        void Vibrate();

        ///<summary>
        /// Only on Android
        /// https://proandroiddev.com/using-vibrate-in-android-b0e3ef5d5e07
        ///</summary>
        void Vibrate(long[] pattern, int repeat);

        void Cancel();

        bool HasVibrator();
    }
}