﻿using System;

namespace 会議室予約.Domain
{
    internal class 予約Id
    {
        private string Value { get; }

        private 予約Id()
        {
            Value = Guid.NewGuid().ToString();
        }
        public 予約Id(string value)
        {
            var guid = Guid.Parse(value);
            Value = guid.ToString();
        }



        public string AsString() {
            return Value.ToString();
        }



        public static 予約Id Create() {
            return new 予約Id();
        }
    }
}