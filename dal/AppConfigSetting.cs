using model;

namespace dal {
    public class AppConfigSetting {
        public static readonly string IniFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sys.ini");

        public static void CreateDefaultIni() {
            if (File.Exists(IniFilePath)) return;
            File.Create(IniFilePath).Close();
            WriteConfig(new AppConfig());
        }
        public static void ReadConfig(ref AppConfig setting) {
            setting.ContactWidth = double.Parse(IniHelper.Read("SYS", "shell_thickness", "0.0001", IniFilePath));
            setting.DefaultSavePath = IniHelper.Read("SYS", "default_save_path", AppDomain.CurrentDomain.BaseDirectory.ToString(), IniFilePath);
        }
        public static void WriteConfig(AppConfig setting) {
            IniHelper.Write("SYS", "shell_thickness", setting.ContactWidth.ToString(), IniFilePath);
            IniHelper.Write("SYS", "default_save_path", setting.DefaultSavePath, IniFilePath);
        }
    }
}
