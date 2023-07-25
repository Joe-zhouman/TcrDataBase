namespace model {
    public static class Constant {
        public static readonly SortedDictionary<PropertyType, string> DATABASE_COL_NAME = new() {
            {PropertyType.ContactMaterial,"contact_material"},
            {PropertyType.ContactMaterial2,"contact_material_2"},
            {PropertyType.InterfacialMaterial,"interfacial_material" },
            {PropertyType.GasCondition,"gas_condition" },
            {PropertyType.RoughnessLb,"roughness_lb" },
            {PropertyType.RoughnessUb,"roughness_ub" },
            {PropertyType.ContactPress,"contact_press"},
            {PropertyType.AtmPress,"atm_press" },
            {PropertyType.InterfacialTemp,"interfacial_temp" },
            {PropertyType.TCR,"tcr" },
            {PropertyType.ID,"id"},
        };
        public static readonly Dictionary<PropertyType, int> IMPORT_FILE_COL_INDEX = new() {
            {PropertyType.ContactMaterial,0},
            {PropertyType.ContactMaterial2,1},
            {PropertyType.InterfacialMaterial,8 },
            {PropertyType.GasCondition,6 },
            {PropertyType.RoughnessLb,2 },
            {PropertyType.RoughnessUb,3 },
            {PropertyType.ContactPress,4},
            {PropertyType.AtmPress,5 },
            {PropertyType.InterfacialTemp,7 },
            {PropertyType.TCR,9 },
        };
    }
}
