using System;

namespace Modul2HW1
{
    public class Result
    {
        private bool _status;
        private string _message;
        public Result()
        {
        }

        public Result(bool status)
        {
            _status = status;
        }

        public Result(bool status, string message)
            {
                _status = status;
                _message = message;
            }
    }
}
