using System.Text.Json.Serialization;

namespace Authorization.Entity
{
    public interface IResponseBase
    {
        bool Success { get; set; }
        string Message { get; set; }
        string folio { get; set; }
    }
}
