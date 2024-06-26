﻿using Clean.Architecture.Business.Common.Models;

namespace Clean.Architecture.Business.Common.Exceptions
{
    [Serializable]
    public class ValidationException : BaseException
    {
        public ValidationException()
        {
        }

        public ValidationException(ErrorResponseDto errorResponse) : base(errorResponse)
        {
        }
    }
}

