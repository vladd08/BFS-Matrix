using System;

namespace BFS.Exceptions
{
    internal sealed class InvalidOrNotExistentMatrixSizeException : Exception
    {
        private new readonly string Message;
        public InvalidOrNotExistentMatrixSizeException(string Message) : base(Message)
        {
            this.Message = Message;
        }

        public string GetMessage()
        {
            return Message;
        }
    }
}
