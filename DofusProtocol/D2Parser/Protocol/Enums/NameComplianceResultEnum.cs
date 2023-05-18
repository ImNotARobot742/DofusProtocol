

// Generated on 05/18/2023 16:29:50
using System;
using System.Collections.Generic;

namespace AmaknaProxy.API.Protocol.Enums
{
    public enum NameComplianceResultEnum
    {
        NAME_OK = 0,
        ERROR_SERVICE_UNAVAILABLE = 1,
        ERROR_NAME_ALREADY_EXISTS = 2,
        ERROR_NAME_WITH_MULTIPLE_ALPHABET = 3,
        ERROR_NAME_BAD_LENGTH = 4,
        ERROR_BAD_CHAR = 5,
        ERROR_INVALID_DASH_POSITION = 6,
        ERROR_NAME_WITH_BAD_CASE = 7,
        ERROR_TOO_MANY_CONSECUTIVE_IDENTICAL = 8,
        ERROR_TOO_MANY_SPECIAL = 9,
        ERROR_FORBIDDEN_NAME = 10,
        ERROR_RESERVED_NAME = 11,
    }
}