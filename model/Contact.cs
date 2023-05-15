namespace model {
    public class Contact {
        public Contact() {
            _contactMaterial = "";
            _interfacialMaterial = "";
        }
        private string _contactMaterial;
        private string _interfacialMaterial;
        public string ContactMaterial {
            get => _contactMaterial;
            set {
                _contactMaterial = value.ToLower();
            }
        }
        public string InterfacialMaterial {
            get => _interfacialMaterial;
            set {
                _interfacialMaterial = value.ToLower();
            }
        }
        public double Roughness { get; set; }
        public double ContactPress { get; set; }
        public double AtmPress { get; set; }
        public double TCR { get; set; }
    }
}
