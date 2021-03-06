// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.


namespace NuGet
{
    internal static class ObjectExtensions
    {
        public static string ToStringSafe(this object obj)
        {
            return obj == null ? null : obj.ToString();
        }
    }
}
