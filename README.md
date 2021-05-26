# Cold Start performance test for different mappers

This repo was created so you can see the difference in the time it takes to load up and execute for the first time different mappers.
This example was created with the following mappers:
* Automapper
* Mapster
* Manual mappings

You can click [here](https://github.com/polgaro/MapperSpeedTest/blob/master/measurements.xlsx) to download the results in my laptop.

Every single one of those numbers is an average of multiple measurements.

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

** Screenshot here

### Step 2
Go to the folder and start executing:

## How do I try it myself -- For linux (Via docker)

### Step 1
This will create a docker container that will point to our local folder.

Make sure you replace the `C:\Users\diego.garber\source\repos\MapperSpeedTest` for your local folder where you have the solution.

The `:/output/` is WHERE you are mounting your folder to.

Please run:

`docker run --rm -it -v C:\Users\diego.garber\source\repos\MapperSpeedTest:/output mcr.microsoft.com/dotnet/sdk:3.1`

** Screenshot here

#### Step 2
You want to publish your code using ready to run.

`dotnet publish -p:PublishReadyToRun=true --self-contained false -f netcoreapp3.1 -r linux-x64`

** Screenshot here
