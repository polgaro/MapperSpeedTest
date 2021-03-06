# Cold Start performance test for different mappers

This repo was created so you can see the difference in the time it takes to load up and execute for the first time different mappers.
This example was created with the following mappers:
* Automapper
* Mapster
* Manual mappings

You can click [here](https://github.com/polgaro/MapperSpeedTest/blob/master/measurements.xlsx) to download the results in my laptop.

Every single one of those numbers is an average of multiple measurements.

## What parameters can I use?
* -c specifies the COUNT. I ran tests with 1, 1000 and 1000000
* -e specifies that it will use explicit mappings (It only applies to Mapster that supports both implicit and explicit mappings)

## Why is this important?
Cold starts are a real concern when building Serverless Applications.
If you are not sure why or you want to have more info about them, you can read my article on cold starts:
https://medium.com/slalom-build/solving-cold-starts-on-aws-lambda-when-using-dotnet-core-51f244f08f60

It turns out that in a normal service, a big part of the cold start time is used on the initialization of the mapper technology that you'll use and performing your first mapping.
A mapper that's really well stablished (like Automapper) is AWESOME in performance for traditional hosting, but has a very steep price for the initial load and the first map.

## How do I try it myself -- For windows

### Step 1
Set your publishing profile in Visual Studio by Right click ==> Publish

Here are my settings (Note: It's EXTREMELY important you enable ReadyToRun compilation. If you have doubts, please [check my previous article](https://medium.com/slalom-build/solving-cold-starts-on-aws-lambda-when-using-dotnet-core-51f244f08f60)

![Image for post](https://github.com/polgaro/MapperSpeedTest/blob/master/Screenshots/VisualStudioPublishProfile.PNG)

NOTE: You have to do this step for EACH one of the projects you want to run (Mapster, Automapper, Manual).

### Step 2
Go to the folder and start executing:

```
MapperSpeedTest.Mapster.exe -c 1
MapperSpeedTest.Mapster.exe -c 1000
MapperSpeedTest.Mapster.exe -c 1000000
```

![Image for post](https://github.com/polgaro/MapperSpeedTest/blob/master/Screenshots/WindowsConsole.PNG)

NOTE: You want to be in the PUBLISH folder (the example for me is `C:\Users\diego.garber\source\repos\MapperSpeedTest\MapperSpeedTest.Mapster\bin\Release\netcoreapp3.1\publish>`. If you run this from just the Release folder, you'd be running the compiled code WITHOUT ReadyToRun and would be considerably slower

![Image for post](https://github.com/polgaro/MapperSpeedTest/blob/master/Screenshots/WindowsConsoleWrongFolder.PNG)

## How do I try it myself -- For linux (Via docker)

### Step 1
This will create a docker container that will point to our local folder.

Make sure you replace the `C:\Users\diego.garber\source\repos\MapperSpeedTest` for your local folder where you have the solution.

The `:/output/` is WHERE you are mounting your folder to.

Please run:

`docker run --rm -it -v C:\Users\diego.garber\source\repos\MapperSpeedTest:/output mcr.microsoft.com/dotnet/sdk:3.1`

![Image for post](https://github.com/polgaro/MapperSpeedTest/blob/master/Screenshots/DockerStarting.PNG)

### Step 2
You want to publish your code using ready to run.

`dotnet publish -p:PublishReadyToRun=true --self-contained false -f netcoreapp3.1 -r linux-x64 -c Release`

### Step 3
Run it!
```
cd ./bin/Release/netcoreapp3.1/linux-x64/publish/
./MapperSpeedTest.Mapster -c 1
```

![Image for post](https://github.com/polgaro/MapperSpeedTest/blob/master/Screenshots/DockerRunning.PNG)
