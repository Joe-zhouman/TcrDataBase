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
        public static readonly Dictionary<PropertyType, int> IMPORT_FILE_COL_INDEX = new() {
            {PropertyType.ContactMaterial,0},
            {PropertyType.InterfacialMaterial,1},
            {PropertyType.Roughness,2},
            {PropertyType.ContactPress,3},
            {PropertyType.AtmPress,4},
            {PropertyType.TCR,5},
        };
    }
}
