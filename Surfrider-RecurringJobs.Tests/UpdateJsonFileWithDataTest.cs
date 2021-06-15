using Azure.Storage.Blobs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Surfrider;
using Surfrider.Jobs;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Surfrider.Jobs_RecurringJobs.Tests
{
    [TestClass]
    public class UpdateJsonFileWithDataTest
    {
     
        
        [TestMethod]
        public void UpdateJsonFileWithData_ContainerNotExists()
        {
            Console.WriteLine("Test 1");
        }
        
        [TestMethod]
        public void UpdateJsonFileWithData_FileAlreadyExists()
        {
            Console.WriteLine("Test 1");
        }
    }
}
