using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Algorithms.TPL
{
    public class ConsoleLoggingContext : SynchronizationContext
    {
        private DateTime _timeOperationStarted;

        public override SynchronizationContext CreateCopy()
        {
            return base.CreateCopy();
        }

        public override void Post(SendOrPostCallback d, object? state)
        {
            base.Post(d, state);
        }

        public override void OperationCompleted()
        {
            base.OperationCompleted();
            var duration = _timeOperationStarted - DateTime.Now;
            Console.WriteLine("Task evaluated for {0} seconds", duration);
        }

        public override void OperationStarted()
        {
            base.OperationStarted();
            _timeOperationStarted = DateTime.Now;
        }
    }
}
