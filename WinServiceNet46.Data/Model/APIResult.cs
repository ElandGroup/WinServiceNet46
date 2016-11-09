namespace WinServiceNet46.Data.Model
{
    public class APIResult
    {
        /// <summary>
        /// 成功时要返回的结果
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// 返回的状态
        /// </summary>
        public ResultType ResultCode { get; set; }
        /// <summary>
        /// 失败的信息
        /// </summary>
        public string Msg { get; set; }
    }

    public enum ResultType
    {
        //成功，并返回期望结果
        Success = 0,
        //报错
        Failure = 1
    }
}
