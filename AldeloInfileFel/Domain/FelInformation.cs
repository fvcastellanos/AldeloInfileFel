namespace AldeloInfileFel.Domain
{
    public class FelInformation
    {
        public string CurrencyCode { get; set; }
        public string DocumentType { get; set; }
        public bool Exportation { get; set; }
        public int AccessNumber { get; set; }
        public string Person { get; set; }
        public GeneratorInformation Generator{ get; set; }
        public ApiInformation ApiInformation{ get; set; }
    }

}
