### 1. How long did you spend on the coding test? What would you add to your solution if you had more time? If you didn't spend much time on the coding test, use this as an opportunity to explain what you would add.
I dedicated approximately three hours to the coding test. Given the limited functionality of the provided API, my primary focus was on effectively implementing the required features. If I had more time, I would consider the following improvements:
- **User Interface**: I'd improve the user interface by refining the styling and ensuring responsiveness for a better overall user experience.
- **Error Handling**: I incorporated error handling into the application to inform users in case of any issues during API requests. Given more time, I'd strengthen error handling further.
- **Testing**: My solution has a basic test. However, with extra time, I'd expand the test suite for better coverage.

### 2. What was the most useful feature added to the latest version of your chosen language? Please include a snippet of code that shows how you've used it.
To me, the most useful feature added in C# 12 was primary constructors, which helps to keep a clean code. I used it in a class on the coding test:
```cs
public class BasicAuth(string username, string password)
{
    public string UserName { get; set; } = username;
    public string Password { get; set; } = password;

    public byte[] Bytes => new UTF8Encoding().GetBytes($"{UserName}:{Password}");

    public Action? ValuesChanged;
}
```

### 3. How would you track down a performance issue in production? Have you ever had to do this?
To troubleshoot a production performance issue, I'd use monitoring tools, profiling, and analyze logs and metrics. Code review helps spot inefficiencies, and benchmarking identifies stress-induced bottlenecks. I've successfully resolved performance issues in a web application in a previous role.

### 4. How would you improve the Lantek API that you just used?
To enhance this API, I'd propose extending it with methods for creating, deleting, updating, and searching by ID. This would not only improve the API's functionality but also make it more versatile.
Besides those improvements, I'd also consider implementing pagination and better filters, introducing caching for better performance and applying rate limiting.