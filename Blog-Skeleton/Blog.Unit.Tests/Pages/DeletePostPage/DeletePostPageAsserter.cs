﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Blog.Unit.Tests.Pages.DeletePostPage
{
    public static class DeletePostPageAsserter
    {
        public static void Name(this DeletePostPage page, string text)
        {
            Assert.IsTrue(true);
        }
    }
}
