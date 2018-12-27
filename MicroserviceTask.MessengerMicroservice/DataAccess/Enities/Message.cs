using System.ComponentModel.DataAnnotations.Schema;

namespace MicroserviceTask.MessagingMicroservice.DataAccess.Entities
{
    public class Message
    {
        public int Id { get; set; }

        private static readonly char delimiter = ';';
        public string _recipients { get; private set; }
        [NotMapped]
        public string[] Recipients
        {
            get
            {
                return _recipients.Split(delimiter);
            }
            set
            {
                _recipients = string.Join($"{delimiter}", value);
            }
        }

        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsSent { get; set; }
    }
}
