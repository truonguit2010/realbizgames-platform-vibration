
namespace RealbizGames.Platform
{
    public class RealVibrationImpl : IRealVibration
    {
        public void Cancel()
        {
            
            Vibration.Cancel();
        }

        public bool HasVibrator()
        {
            return Vibration.HasVibrator();
        }

        public void Init()
        {
            Vibration.Init();
        }

        public void Vibrate(long milliseconds)
        {
            if (VibrationConfig.DefaultInstance.enable) {
                Vibration.Vibrate(milliseconds: milliseconds);
            }
        }

        public void Vibrate()
        {
            if (VibrationConfig.DefaultInstance.enable) {
                Vibration.Vibrate();
            }
        }

        public void Vibrate(long[] pattern, int repeat)
        {
            if (VibrationConfig.DefaultInstance.enable) {
                Vibration.Vibrate(pattern: pattern, repeat: repeat);
            }
        }

        public void VibrateNope()
        {
            if (VibrationConfig.DefaultInstance.enable) {
                Vibration.VibrateNope();
            }
        }

        public void VibratePeek()
        {
            if (VibrationConfig.DefaultInstance.enable) {
                Vibration.VibratePeek();
            }
        }

        public void VibratePop()
        {
            if (VibrationConfig.DefaultInstance.enable) {
                Vibration.VibratePop();
            }
        }
    }
}