using System;

namespace BFS.Exceptions
{
    internal sealed class ElementAlreadySetException : Exception
    {
        private new readonly string Message;
        public ElementAlreadySetException(string Message) : base(Message)
        {
            this.Message = Message;
        }

        public string GetMessage()
        {
            return Message;
        }
    }
    internal sealed class StartElementAlreadySetException : Exception
    {
        private new readonly string Message;
        public StartElementAlreadySetException(string Message) : base(Message)
        {
            this.Message = Message;
        }

        public string GetMessage()
        {
            return Message;
        }
    }
}
