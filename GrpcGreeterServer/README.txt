Run the server as https

The GRPC can be tried through Postman
Add https://localhost:7235 and you should see a SayHello method which you can call

The transcoding can be tested from swagger UI in a browser
The end point for this is defined in the Program.cs
Go to https://localhost:7235/swagger/index.html

The JSON service can be accessed in a browser
Go to https://localhost:7235/v1/greeter/foo
This end point is defined in the greet.proto
