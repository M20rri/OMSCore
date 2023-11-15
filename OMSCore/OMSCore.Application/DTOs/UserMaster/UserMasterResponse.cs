using System;

namespace OMSCore.Application.DTOs.UserMaster
{
    public class UserMasterResponse
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int? Location { get; set; }
        public string EmailId { get; set; }
        public string Phone { get; set; }
        public DateTime? CrerationDate { get; set; }
        public DateTime? ValidTill { get; set; }
        public sbyte? Blocked { get; set; }
        public string BlockedMessage { get; set; }
    }
}
