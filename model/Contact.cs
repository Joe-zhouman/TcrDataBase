namespace model {
    public class Contact {
        public Contact() {
            _contactMaterial = "";
            _contactMaterial2 = "";
            _interfacialMaterial = "";
            _gasCondition = "";
        }
        private string _contactMaterial;
        private string _contactMaterial2;
        private string _interfacialMaterial;
        private string _gasCondition;
        public string ContactMaterial {
            get => _contactMaterial;
            set {
                _contactMaterial = value.ToLower();
            }
        }
        public string ContactMaterial2 {
            get => _contactMaterial2;
            set {
                _contactMaterial2 = value.ToLower();
            }
        }
        public string InterfacialMaterial {
            get => _interfacialMaterial;
            set {
                _interfacialMaterial = value.ToLower();
            }
        }
        public string GasCondtion {
            get => _gasCondition;
            set {
                _gasCondition = value.ToLower();
            }
        }
        public double RoughnessLb { get; set; }
        public double RoughnessUb { get; set; }
        public double ContactPress { get; set; }
        public double AtmPress { get; set; }
        public double InterfacialTemp { get; set; }
        public double TCR { get; set; }
    }
}
