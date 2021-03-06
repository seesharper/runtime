// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using Xunit;

namespace System.Runtime.CompilerServices.Tests
{
    public class IUnknownConstantAttributeTests
    {
        [Fact]
        public void Ctor_Default()
        {
            var attribute = new IUnknownConstantAttribute();
            UnknownWrapper wrapper = Assert.IsType<UnknownWrapper>(attribute.Value);
            Assert.Null(wrapper.WrappedObject);
        }
    }
}
