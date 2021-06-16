using Azure.Storage.Blobs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Surfrider;
using Surfrider.Jobs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Surfrider.Jobs_RecurringJobs.Tests
{
    [TestClass]
    public class RiverPipelinesTest
    {

        [TestCleanup()]
        public void Cleanup()
        {
           // do stuff
        }

        [TestMethod]
        public async Task RetrieveSuccessfullComputedCampaignsRiversAsync_SUCCESS()
        {
           
            Assert.IsTrue(true);
            
            
        }
        [TestMethod]
        public async Task MarkRiverPipelineAsFailedAsync_SUCCESS()
        {
           Assert.IsTrue(true);
        }
        
    }
}
