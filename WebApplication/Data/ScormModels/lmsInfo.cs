using System;

namespace Models
{
    [Serializable]
    public class LMSInfo
    {
        public LMSInfo()
        {
        }
        public string sessionId { get; set; }
        public string userId { get; set; }
        public string coreId { get; set; }
        public string scoIdentifier { get; set; }
        public string scormCourseId { get; set; }
        public string dataItem { get; set; }
        public string dataValue { get; set; }
        public string errorCode { get; set; }
        public string errorString { get; set; }
        public string errorDiagnostic { get; set; }
        public string returnValue { get; set; }
    }
}

