using System.Threading;
using System.Threading.Tasks;
using Algorithms.TPL;
using NUnit.Framework;

namespace Algorithms_Tests
{
    public class ContextsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Create_LoggingContext_FromTask()
        {
            var lc = new ConsoleLoggingContext();
            SynchronizationContext.SetSynchronizationContext(lc);
            var testTask = Task.Factory.StartNew(DummmyTask);
            var continuationTask = Task.Factory.StartNew(DummmyTask);
            Task.Factory.ContinueWhenAny(new[] { testTask }, task => continuationTask);
            continuationTask.Wait();
            Assert.AreEqual(testTask.Status, TaskStatus.RanToCompletion);
            Assert.AreEqual(continuationTask.Status, TaskStatus.RanToCompletion);
        }

        public void DummmyTask()
        {
            Thread.Sleep(2000);
            Thread.Sleep(2000);
        }
    }
}