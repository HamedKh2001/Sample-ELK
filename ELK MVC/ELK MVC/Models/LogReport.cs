using Newtonsoft.Json;

namespace Sample_ELK
{
    public class LogReport
    {
        [JsonProperty("@timestamp")]
        public DateTimeOffset timestamp { get; set; }
        public string level { get; set; }
        public string messageTemplate { get; set; }
        public string message { get; set; }
        public List<Exception> exceptions { get; set; }
        public Fields fields { get; set; }
    }

    public class Fields
    {
        public object bytes_received { get; set; }
        public object bytes_sent { get; set; }
        public string http_user_agent { get; set; }
        public string hostname { get; set; }
        public string request_method { get; set; }
        public string uri { get; set; }
        public string server_protocol { get; set; }
        public int LocalPort { get; set; }
        public string server_addr { get; set; }
        public string query_string { get; set; }
        public int status { get; set; }
        public int RemotePort { get; set; }
        public string remote_addr { get; set; }
        public object remote_user { get; set; }
        public string ActionId { get; set; }
        public string ActionName { get; set; }
        public string RequestId { get; set; }
        public string RequestPath { get; set; }
        public string ConnectionId { get; set; }
        public string ApplicationName { get; set; }
        public string Environment { get; set; }
        public Exceptiondetail ExceptionDetail { get; set; }
    }

    public class Eventid
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Exceptiondetail
    {
        public string Type { get; set; }
        public int HResult { get; set; }
        public string Message { get; set; }
        public string Source { get; set; }
    }

    public class Exception
    {
        public int Depth { get; set; }
        public string ClassName { get; set; }
        public string Message { get; set; }
        public string Source { get; set; }
        public string StackTraceString { get; set; }
        public object RemoteStackTraceString { get; set; }
        public int RemoteStackIndex { get; set; }
        public int HResult { get; set; }
        public object HelpURL { get; set; }
    }
}