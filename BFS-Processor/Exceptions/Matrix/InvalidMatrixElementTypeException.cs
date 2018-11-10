using System;

namespace BFS.Exceptions
{
    internal sealed class InvalidMatrixElementTypeException : Exception
    {
        private new readonly string Message;
        public InvalidMatrixElementTypeException(string Message) : base(Message)
        {
            this.Message = Message;
        }

        public string GetMessage()
        {
            return Message;
        }
    }
}
