using System;

namespace BFS.Exceptions
{
    class InvalidOrNotExistentMatrixSizeException : Exception
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
