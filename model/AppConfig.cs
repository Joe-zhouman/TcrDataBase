namespace model {
    public class AppConfig {
        public double ContactWidth { get; set; }
        public string DefaultSavePath { get; set; }
        public double TcrTransFactor { get; set; }
        public AppConfig(double contactWidth,
                         string defaultSavePath) {
            ContactWidth = contactWidth;
            DefaultSavePath = defaultSavePath;
        }
        public AppConfig() {
            ContactWidth = 1e-4;
            DefaultSavePath = ".";
            TcrTransFactor = 1e6;
        }
    }
}
