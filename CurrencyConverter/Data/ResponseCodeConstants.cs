namespace CurrencyConverter.Data
{
    public class ResponseCodeConstants
    {
        static ResponseCodeConstants()
        {
        }

        #region Web
        public static StatusCodeConstants Web_Info_RequestSuccess = new StatusCodeConstants(string.Format("{0}-{1}-{2}", SystemLayerConstants.Web, ErrorSeverityConstants.Info, WebCodeConstants.Req_Success)
                                                                       , "Request completed successfully.", "");

        public static StatusCodeConstants Web_Info_AuthSuccess = new StatusCodeConstants(string.Format("{0}-{1}-{2}", SystemLayerConstants.Web, ErrorSeverityConstants.Info, WebCodeConstants.Auth_Success),
                                                                        "Request authentication is successfull.", "");

        public static StatusCodeConstants Web_Error_AuthFailed = new StatusCodeConstants(string.Format("{0}-{1}-{2}", SystemLayerConstants.Web, ErrorSeverityConstants.Error, WebCodeConstants.Auth_Failure),
                                                                        "Request authentication failed", "Verify auth token is present and is a valid token.");
        public static StatusCodeConstants Web_Error_InternalServerError = new StatusCodeConstants(string.Format("{0}-{1}-{2}", SystemLayerConstants.Web, ErrorSeverityConstants.Error, WebCodeConstants.InternalServerError),
                                                                          "Internal error while processing.", "Retry after a few moments or contact support and provide them with error code and message.");
        public static StatusCodeConstants Web_Warning_PoorlyFormatReqBody = new StatusCodeConstants(string.Format("{0}-{1}-{2}", SystemLayerConstants.Web, ErrorSeverityConstants.Warning, WebCodeConstants.ReqBody_PoorFromat),
                                                                        "Request body is not formatted properly.", "Try building request body according to Api documentation.");

        #endregion
    }
    public class WebCodeConstants
    {
        public static string Req_Success = "002";
        public static string Auth_Success = "004";
        public static string Auth_Failure = "003";
        public static string ReqBody_PoorFromat = "005";
        public static string InternalServerError = "007";

    }
}
