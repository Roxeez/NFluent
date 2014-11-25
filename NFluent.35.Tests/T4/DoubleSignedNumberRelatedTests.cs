﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="DoubleSignedNumberRelatedTests.cs" company="">
// //   Copyright 2013 Thomas PIERRAIN
// //   Licensed under the Apache License, Version 2.0 (the "License");
// //   you may not use this file except in compliance with the License.
// //   You may obtain a copy of the License at
// //       http://www.apache.org/licenses/LICENSE-2.0
// //   Unless required by applicable law or agreed to in writing, software
// //   distributed under the License is distributed on an "AS IS" BASIS,
// //   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// //   See the License for the specific language governing permissions and
// //   limitations under the License.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------
namespace NFluent.Tests
{
    using System.Globalization;
    using System.Threading;

    using NUnit.Framework;

    [TestFixture]
    public class DoubleSignedNumberRelatedTests
    {
        #pragma warning disable 169

        //// ---------------------- WARNING ----------------------
        //// AUTO-GENERATED FILE WHICH SHOULD NOT BE MODIFIED!
        //// To change this class, change the one that is used
        //// as the golden source/model for this autogeneration
        //// (i.e. the one dedicated to the integer values).
        //// -----------------------------------------------------

        #pragma warning restore 169
        private CultureInfo savedCulture;

        [SetUp]
        public void SetUp()
        {
            // Important so that ToString() versions of decimal works whatever the current culture.
            this.savedCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("fr-FR");
        }

        [TearDown]
        public void TearDown()
        {
            // Boy scout rule ;-)
            Thread.CurrentThread.CurrentCulture = this.savedCulture;
        }

        #region IsPositive (obsolete)

        [Test]
        public void IsPositiveWorks()
        {
            const double Two = 2D;

            Check.That(Two).IsPositive();
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked value is not strictly positive (i.e. greater than zero).\nThe checked value:\n\t[0]")]
        public void IsPositiveThrowsExceptionWhenEqualToZero()
        {
            const double Zero = 0D;
            Check.That(Zero).IsPositive();
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked value is strictly positive (i.e. greater than zero), whereas it must not.\nThe checked value:\n\t[2]")]
        public void NotIsPositiveThrowsExceptionWhenFailing()
        {
            const double Two = 2D;

            Check.That(Two).Not.IsPositive();
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked value is not strictly positive (i.e. greater than zero).\nThe checked value:\n\t[-50]")]
        public void IsPositiveThrowsExceptionWhenValueIsNegative()
        {
            const double MinusFifty = -50D;

            Check.That(MinusFifty).IsPositive();
        }

        [Test]
        public void NotIsPositiveWorks()
        {
            const double MinusFifty = -50D;

            Check.That(MinusFifty).Not.IsPositive();
        }

        #endregion

        #region IsStrictlyPositive

        [Test]
        public void IsStrictlyPositiveWorks()
        {
            const double Two = 2D;

            Check.That(Two).IsStrictlyPositive();
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked value is not strictly positive (i.e. greater than zero).\nThe checked value:\n\t[0]")]
        public void IsStrictlyPositiveThrowsExceptionWhenEqualToZero()
        {
            const double Zero = 0D;
            Check.That(Zero).IsStrictlyPositive();
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked value is strictly positive (i.e. greater than zero), whereas it must not.\nThe checked value:\n\t[2]")]
        public void NotIsStrictlyPositiveThrowsExceptionWhenFailing()
        {
            const double Two = 2D;

            Check.That(Two).Not.IsStrictlyPositive();
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked value is not strictly positive (i.e. greater than zero).\nThe checked value:\n\t[-50]")]
        public void IsStrictlyPositiveThrowsExceptionWhenValueIsNegative()
        {
            const double MinusFifty = -50D;

            Check.That(MinusFifty).IsStrictlyPositive();
        }

        [Test]
        public void NotIsStrictlyPositiveWorks()
        {
            const double MinusFifty = -50D;

            Check.That(MinusFifty).Not.IsStrictlyPositive();
        }

        #endregion

        #region IsNegative (obsolete)

        [Test]
        public void IsNegativeWorks()
        {
            const double MinusFifty = -50D;

            Check.That(MinusFifty).IsNegative();
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked value is not less than zero.\nThe checked value:\n\t[0]")]
        public void IsNegativeThrowsExceptionWhenEqualToZero()
        {
            const double Zero = 0D;
            Check.That(Zero).IsNegative();
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked value is less than zero, whereas it must not.\nThe checked value:\n\t[-50]")]
        public void NotIsNegativeThrowsExceptionWhenFailing()
        {
            const double MinusFifty = -50D;

            Check.That(MinusFifty).Not.IsNegative();
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked value is not less than zero.\nThe checked value:\n\t[2]")]
        public void IsNegativeThrowsExceptionWhenValueIsPositive()
        {
            const double Two = 2D;

            Check.That(Two).IsNegative();
        }

        [Test]
        public void NotIsNegativeWorks()
        {
            const double Two = 2D;

            Check.That(Two).Not.IsNegative();
        }

        #endregion

        #region IsLessThanZero

        [Test]
        public void IsLessThanZeroWorks()
        {
            const double MinusFifty = -50D;

            Check.That(MinusFifty).IsLessThanZero();
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked value is not less than zero.\nThe checked value:\n\t[0]")]
        public void IsLessThanZeroThrowsExceptionWhenEqualToZero()
        {
            const double Zero = 0D;
            Check.That(Zero).IsLessThanZero();
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked value is less than zero, whereas it must not.\nThe checked value:\n\t[-50]")]
        public void NotIsLessThanZeroThrowsExceptionWhenFailing()
        {
            const double MinusFifty = -50D;

            Check.That(MinusFifty).Not.IsLessThanZero();
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked value is not less than zero.\nThe checked value:\n\t[2]")]
        public void IsLessThanZeroThrowsExceptionWhenValueIsPositive()
        {
            const double Two = 2D;

            Check.That(Two).IsLessThanZero();
        }

        [Test]
        public void NotIsLessThanZeroWorks()
        {
            const double Two = 2D;

            Check.That(Two).Not.IsLessThanZero();
        }

        #endregion
    }
}
