﻿ // --------------------------------------------------------------------------------------------------------------------
 // <copyright file="UlongCheckExtensions.cs" company="">
 //   Copyright 2013 Thomas PIERRAIN
 //   Licensed under the Apache License, Version 2.0 (the "License");
 //   you may not use this file except in compliance with the License.
 //   You may obtain a copy of the License at
 //       http://www.apache.org/licenses/LICENSE-2.0
 //   Unless required by applicable law or agreed to in writing, software
 //   distributed under the License is distributed on an "AS IS" BASIS,
 //   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 //   See the License for the specific language governing permissions and
 //   limitations under the License.
 // </copyright>
 // --------------------------------------------------------------------------------------------------------------------

namespace NFluent
{
    using System;

    using Extensibility;

    using Helpers;

    using Kernel;

    /// <summary>
    /// Provides check methods to be executed on an <see cref="ulong"/> value.
    /// </summary>
    public static class UlongCheckExtensions
    {
        // DoNotChangeOrRemoveThisLine

        #pragma warning restore 169

        /// <summary>
        /// Determines whether the specified value is before the other one.
        /// </summary>
        /// <param name="check">The fluent check to be extended.</param>
        /// <param name="givenValue">The other value.</param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">The current value is not before the other one.</exception>
        public static ICheckLink<ICheck<ulong>> IsBefore(this ICheck<ulong> check, ulong givenValue)
        {
            ExtensibilityHelper.BeginCheck(check)
                .ComparingTo(givenValue, "before", "after")
                .FailWhen(sut => sut.CompareTo(givenValue) >= 0, "The {0} is not before the reference value.")
                .Negates("The {0} is before the reference value whereas it must not.")
                .EndCheck();
            return ExtensibilityHelper.BuildCheckLink(check);
        }

        /// <summary>
        /// Determines whether the specified value is after the other one.
        /// </summary>
        /// <param name="check">The fluent check to be extended.</param>
        /// <param name="givenValue">The other value.</param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">The current value is not after the other one.</exception>
        public static ICheckLink<ICheck<ulong>> IsAfter(this ICheck<ulong> check, ulong givenValue)
        {
            ExtensibilityHelper.BeginCheck(check)
                .ComparingTo(givenValue, "after", "before")
                .FailWhen(sut => sut.CompareTo(givenValue) <= 0, "The {0} is not after the reference value.")
                .Negates("The {0} is after the reference value whereas it must not.")
                .EndCheck();
            return ExtensibilityHelper.BuildCheckLink(check);
        }

        /// <summary>
        /// Checks that the actual value is equal to zero.
        /// </summary>
        /// <param name="check">The fluent check to be extended.</param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">The value is not equal to zero.</exception>
        public static ICheckLink<ICheck<ulong>> IsZero(this ICheck<ulong> check)
        {
            return new NumberCheck<ulong>(check).IsZero();
        }

        /// <summary>
        /// Checks that the actual nullable value has a value and thus, is not null.
        /// </summary>
        /// <param name="check">The fluent check to be extended.</param>
        /// <returns>A check link.</returns>
        /// <exception cref="FluentCheckException">The value is null.</exception>
        public static INullableOrNumberCheckLink<ulong> HasAValue(this ICheck<ulong?> check)
        {
            ExtensibilityHelper.BeginCheck(check)
                .SutNameIs("nullable")
                .FailIfNull("The {0} has no value, which is unexpected.")
                .Negates("The {0} has a value, whereas it must not.")
                .EndCheck();

            return new NullableOrNumberCheckLink<ulong>(check);
        }

        /// <summary>
        /// Checks that the actual nullable value has no value and thus, is null. 
        /// Note: this method does not return A check link since the nullable is null.
        /// </summary>
        /// <param name="check">The fluent check to be extended.</param>
        /// <exception cref="FluentCheckException">The value is not null.</exception>
        public static void HasNoValue(this ICheck<ulong?> check)
        {
            check.Not.HasAValue();
        }

        /// <summary>
        /// Checks that the actual value is NOT equal to zero.
        /// </summary>
        /// <param name="check">The fluent check to be extended.</param>
        /// <returns>
        ///   <returns>A check link.</returns>
        /// </returns>
        /// <exception cref="FluentCheckException">The value is equal to zero.</exception>
        public static ICheckLink<ICheck<ulong>> IsNotZero(this ICheck<ulong> check)
        {
            return check.Not.IsZero();
        }

        /// <summary>
        /// Checks that the actual value is less than an operand.
        /// </summary>
        /// <param name="check">
        /// The fluent check to be extended.
        /// </param>
        /// <param name="comparand">
        /// Comparand to compare the value to.
        /// </param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">
        /// The value is not less than the comparand.
        /// </exception>
        [Obsolete("Use IsStrictlyLessThan instead.")]
        public static ICheckLink<ICheck<ulong>> IsLessThan(this ICheck<ulong> check, ulong comparand)
        {
            return check.Not.IsStrictlyGreaterThan(comparand);
        }

        /// <summary>
        /// Checks that the checked value is strictly less than the comparand.
        /// </summary>
        /// <param name="check">
        /// The fluent check to be extended.
        /// </param>
        /// <param name="comparand">
        /// Comparand to compare the value to.
        /// </param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">
        /// The value is not strictly less than the comparand.
        /// </exception>
        public static ICheckLink<ICheck<ulong>> IsStrictlyLessThan(this ICheck<ulong> check, ulong comparand)
        {
            return new NumberCheck<ulong>(check).IsStrictlyLessThan(comparand);
        }

        /// <summary>
        /// Checks that the actual value is more than an operand.
        /// </summary>
        /// <param name="check">
        /// The fluent check to be extended.
        /// </param>
        /// <param name="comparand">
        /// Comparand to compare the value to.
        /// </param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">
        /// The value is not less than the comparand.
        /// </exception>
        [Obsolete("Use IsStrictlyGreaterThan instead.")]
        public static ICheckLink<ICheck<ulong>> IsGreaterThan(this ICheck<ulong> check, ulong comparand)
        {
            return check.Not.IsStrictlyLessThan(comparand);
        }

        /// <summary>
        /// Checks that the checked value is strictly greater than the comparand.
        /// </summary>
        /// <param name="check">
        /// The fluent check to be extended.
        /// </param>
        /// <param name="comparand">
        /// Comparand to compare the value to.
        /// </param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">
        /// The checked value is not strictly greater than the comparand.
        /// </exception>
        public static ICheckLink<ICheck<ulong>> IsStrictlyGreaterThan(this ICheck<ulong> check, ulong comparand)
        {
            return new NumberCheck<ulong>(check).IsStrictlyGreaterThan(comparand);
        }

        /// <summary>
        /// Checks that the actual value is equal to another expected value.
        /// </summary>
        /// <param name="check">
        /// The fluent check to be extended.
        /// </param>
        /// <param name="expected">
        /// The expected value.
        /// </param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">
        /// The actual value is not equal to the expected value.
        /// </exception>
        public static ICheckLink<ICheck<ulong>> IsEqualTo(this ICheck<ulong> check, ulong expected)
        {
            return EqualityHelper.PerformEqualCheck(check , expected);
        }
    }
}
