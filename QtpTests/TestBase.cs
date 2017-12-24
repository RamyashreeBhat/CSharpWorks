using Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtpTests
{
    public class TestBase
    {
        [TestInitialize]
        public void Initialize() {
            Browser.Initialize();
        }

        [TestCleanup]
        public void CleanUp()
        {
          Browser.Close();
        }

    }

  
}
