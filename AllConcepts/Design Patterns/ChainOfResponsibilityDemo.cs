using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public abstract class AbstractLogger
    {
        static public int FileLogger = 0;
        static public int ConsoleLogger = 1;
        static public int DBLogger = 2;
        public int loglevel;
        public abstract void Write(string message);
        public AbstractLogger _nextLogger;

        public void LogMessage(int level, string message)
        {
            if (this.loglevel == level)
            {
                Write(message);
                return;
            }
            else
            {
                _nextLogger.LogMessage(level, message);
            }
        }
    }

    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int _level)
        {
            this.loglevel = _level;
        }
        public override void Write(string message)
        {
            Console.WriteLine("Console Logger - " + message);
        }
    }

    public class FileLogger : AbstractLogger
    {
        public FileLogger(int _level)
        {
            this.loglevel = _level;
        }
        public override void Write(string message)
        {
            Console.WriteLine("File Logger - " + message);
        }
    }

    public class DbLogger : AbstractLogger
    {
        public DbLogger(int _level)
        {
            this.loglevel = _level;
        }
        public override void Write(string message)
        {
            Console.WriteLine("Db Logger - " + message);
        }
    }
    public class ChainOfResponsibilityDemo
    {
        private AbstractLogger SetChainOfResponsibility()
        {
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.ConsoleLogger);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.FileLogger);
            AbstractLogger DbLogger = new DbLogger(AbstractLogger.DBLogger);

            consoleLogger._nextLogger = fileLogger;
            fileLogger._nextLogger = DbLogger;

            return consoleLogger;
        }
        public void TestCOR()
        {
            AbstractLogger logger = SetChainOfResponsibility();
            logger.LogMessage(AbstractLogger.DBLogger, "This is log message");
        }
    }
}
