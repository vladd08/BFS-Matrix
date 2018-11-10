using System;

namespace BFS.Exceptions
{
    class PositionAlreadySetException : Exception
    {
        private new readonly string Message;
        public PositionAlreadySetException(string Message) : base(Message)
        {
            this.Message = Message;
        }

        public string GetMessage()
        {
            return Message;
        }
    }
    class StartPositionAlreadySetException : Exception
    {
        private new readonly string Message;
        public StartPositionAlreadySetException(string Message) : base(Message)
        {
            this.Message = Message;
        }

        public string GetMessage()
        {
            return Message;
        }
    }
}
