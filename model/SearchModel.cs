namespace model {
    public class SearchModel {
        public double? RoughnessLb;
        public double? RoughnessUb;
        public double? ContactPressLb;
        public double? ContactPressUb;
        public double? AtmPressLb;
        public double? AtmPressUb;
        public string? ContactMaterials;
        public string? InterfacialMaterials;
        public List<Contact>? SearchResult;
        //private void SetList(string? value, ref List<string>? list) {
        //    if (value is null) {
        //        list = null;
        //    }
        //    else {
        //        list = value.Split(new Char[] { ',', '，' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        //    }
        //}
    }
}
