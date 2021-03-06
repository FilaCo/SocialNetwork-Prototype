﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public enum TMessage
    {
        FULLNAME_CHANGED, DATEOFBIRTH_CHANGED, GENDER_CHANGED, STATUS_CHANGED, SCHOOL_CHANGED, HIGHSCHOOL_CHANGED,
        FRIEND_ADDED, NEWS_ADDED, PICTURE_ADDED, FRIEND_DELETED, NEWS_DELETED, PICTURE_DELETED, BIRTHDAY, PROFILE_PIC_CHANGED
    }
    class TJournalEntry 
    {
        public string Source { get; set; }
        public TMessage MessageType { get; set; }
        public DateTime TimeArrived { get; set; }
        public string MessageInfo { get; set; }
        public TJournalEntry(string _source, TMessage _msgType, DateTime _timeArrived, string _msgInfo)
        {
            Source = _source;
            MessageType = _msgType;
            TimeArrived = _timeArrived;
            MessageInfo = _msgInfo;
        }
        public override string ToString()
        {
            return string.Format($"Источник сообщения: {Source};\nКатегория сообщения: {MessageType};\nВремя: {TimeArrived}\n" +
                $"Сведения о сообщении: {MessageInfo}");
        }

        public override bool Equals(object obj)
        {
            if (MessageType != TMessage.BIRTHDAY)
                return false;
            TJournalEntry je = (TJournalEntry)obj;            
            if (Source == je.Source && MessageType == je.MessageType && MessageInfo == je.MessageInfo)
                return true;
            return false;
        }
    }
}
