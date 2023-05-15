namespace model {
    public static class Constant {
        public static readonly SortedDictionary<PropertyType, string> DATABASE_COL_NAME = new() {
            {PropertyType.ContactMaterial,"contact_material"},
            {PropertyType.InterfacialMaterial,"interfacial_material" },
            {PropertyType.Roughness,"roughness" },
            {PropertyType.ContactPress,"contact_press"},
            {PropertyType.AtmPress,"atm_press" },
            {PropertyType.TCR,"tcr" },
            {PropertyType.ID,"id"},
        };
    }
}
