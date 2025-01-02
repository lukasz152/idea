using Abstractions.Kernel;
using Core.ValueObjects;

namespace Core.Entities
{
    public sealed class Status : Entity
    {
        public DateTime? DateToFinish { get; private set; }
        public StatusCode StatusCode { get; private set; }
        public Status(DateTime? dateToFinish, StatusCode statusCode)
        {
            DateToFinish = dateToFinish;
            StatusCode = statusCode;
        }

        public void Update(DateTime? dateToFinish, StatusCode statusCode)
        {
            DateToFinish = dateToFinish;
            StatusCode = statusCode;
        }

        public void UpdateDateToFinish(DateTime? dateToFinish) 
        {
            DateToFinish = dateToFinish;
        }

        public void UpdateStatusCode(StatusCode statusCode) 
        {
            StatusCode = statusCode;
        }
    }
}
