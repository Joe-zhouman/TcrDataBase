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
        public string ToSqlSearchQuery() {
            return $@"contact_material='{ContactMaterial}'
AND interfacial_material='{InterfacialMaterial}'
AND roughness BETWEEN {Roughness * .99} AND {Roughness * 1.01}
AND contact_press BETWEEN {ContactPress * .99} AND {ContactPress * 1.01}
AND atm_press BETWEEN {AtmPress * .99} AND {AtmPress * 1.01}";
        }
    }
}
