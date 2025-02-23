﻿using System;

namespace NetOffice.Attributes
{
    /// <summary>
    /// This enumerator is not supported from the com proxy instance, its a custom service from NetOffice
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public sealed class CustomEnumeratorAttribute : System.Attribute
    {
    }
}
