
namespace RealbizGames.Platform
{
    public class VibrationConfig
    {
        private static VibrationConfig _DefaultInstance;
        public static VibrationConfig DefaultInstance {
            get {
                if (_DefaultInstance == null) {
                    _DefaultInstance = new VibrationConfig();
                }
                return _DefaultInstance;
            }
        }

        public bool enable;
    }
}