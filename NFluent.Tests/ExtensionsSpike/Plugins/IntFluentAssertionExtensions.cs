﻿    namespace Spike.Plugins
{
    using System;

    using Spike.Core;

    public static class IntFluentAssertionExtensions
    {
        public static IFluentAssertion<int> IsCoolNumber(this IFluentAssertion<int> fluentAssertion)
        {
            if (fluentAssertion.Sut != 42)
            {
                throw new Exception("Not cool, try 42!");
            }
            return fluentAssertion;
        }
    }
}