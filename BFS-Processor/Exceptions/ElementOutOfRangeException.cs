using System;

namespace BFS.Exceptions
{
    internal sealed class ElementOutOfRangeException : Exception
    {
        private new readonly string Message;
        public ElementOutOfRangeException(string Message) : base(Message)
        {
            this.Message = Message;
        }

        public string GetMessage()
        {
            return Message;
        }
    }
}
