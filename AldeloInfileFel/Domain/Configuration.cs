﻿namespace AldeloInfileFel.Domain
{
    public class Configuration
    {
        public string AldeloDbConnectionString { get; set; }
        public string FelApiUrl { get; set; }
        public string FelApiHealth { get; set; }
        public string FelApiInfo { get; set; }
        public string TipDescription { get; set; }
        public string PreviewUrl { get; set; }
        public string TipAmountQuery { get; set; }
        public string TipProcessingType { get; set; }
        public string InfileTaxIdQueryUrl { get; set; }
        public string InfileIdQueryUrl { get; set; }
        public string InfileIdQueryLoginUrl { get; set; }
        public string InfileTenantKey { get; set; }
        public string InfileTenantCode { get; set; }
        public string OrderInformationCustomQuery { get; set; }
        public string InternalDbConnectionString { get; set; }
    }
}
