using System;

namespace StoneMessage.Events
{
    public class BaseEvent
    {
       
        public Guid Id  { get; set; }
        public DateTime CreateDate { get; set; }

        public BaseEvent()
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.Now;
        }

        public BaseEvent(Guid id, DateTime createDate)
        {
            Id = id;
            CreateDate = createDate;
        }
    }
}
