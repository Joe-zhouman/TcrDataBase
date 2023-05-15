namespace model {
    public enum ColType {
        ContactMaterial,
        InterfacialMaterial,
        Roughness,
        ContactPress,
        AtmPress,
    }
    public static class Constant {
        public static readonly Dictionary<ColType, string> DATABASE_COL_NAME = new Dictionary<ColType, string>() {
            {ColType.ContactMaterial,"contact_material"},
            {ColType.InterfacialMaterial,"interfacial_material" },
            {ColType.Roughness,"roughness" },
            {ColType.ContactPress,"contact_press"},
            {ColType.AtmPress,"atm_press" }
        };
    }
}
