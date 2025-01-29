// Dependency Inversion Principle (DIP)
// High-level modules should not depend on low-level modules. Both should depend on an abstraction.

// DIP violation
// A high-level class depends directly on a low-level class

class FileLogger {
    public void Log(string message) {
        Console.WriteLine($"File log: {message}")
    }
}

class Application {
    private FileLogger _logger;

    public Application() {
        _logger = new FileLogger();
    }

    public void Run() {
        _logger.Log("Application is running...");
    }
}

// DIP Adherance
// fix: introduce an abstraction (interface) and depend on it rather than a specific class.

interface ILogger {
    void Log(string message);
}

class FileLogger : ILogger {
    public void Log(string message) {
        // pretend this writes to a text file
        Console.WriteLine($"File log: {message}")
    }
}

class ConsoleLogger : ILogger {
    public void Log(string message) {
        Console.WriteLine($"Console log: {message}");
    }
}

class Application {
    private readonly ILogger _logger;

    public Application(ILogger logger) {
        _logger = logger;
    }

    public void Run() {
        _logger.Log("Application is running...")
    }
}


// we can change whatever logger type we use in the constructor because of DIP adherance
Application myApp = new Application(ConsoleLogger);
myApp.Run();