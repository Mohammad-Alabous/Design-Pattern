using System.ComponentModel;

namespace ME_Singleton {
    public class SettingsManager{
        private SettingsManager(){

        }

        private static readonly object _lock  = new object();

        private static SettingsManager? _instance;
        private Dictionary<string, string> _settings = new Dictionary<string, string>();

        public static SettingsManager Instance{
            get
            {
                lock(_lock) {
                    if (_instance == null){
                        _instance = new SettingsManager();
                    }
                    return _instance;
                }
            }
        }

        public void Set(string key, string value) {
            if (!_settings.ContainsKey(key)) {
                _settings.Add(key, value);
                return;
            }
            
            _settings[key] = value;
        }

        public string Get(string key){
            if (!_settings.ContainsKey(key)) throw new Exception("Key not found!");

            return _settings[key];
        }
    }
}