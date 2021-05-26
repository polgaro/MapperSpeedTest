# Cold Start performance test for different mappers

This repo was created so you can see the difference in the time it takes to load up and execute for the first time different mappers.
This example was created with the following mappers:
* Automapper
* Mapster
* Manual mappings

You can download this file that shows the results in my laptop.

Link here to the file.

Every single one of those numbers is an average of multiple measurements.

## Why is this important?
Cold starts are a real concern when building Serverless Applications.
If you are not sure why or you want to have more info about them, you can read my article on cold starts:
https://medium.com/slalom-build/solving-cold-starts-on-aws-lambda-when-using-dotnet-core-51f244f08f60

It turns out that in a normal service, a big part of the cold start time is used on the initialization of the mapper technology that you'll use and performing your first mapping.
A mapper that's really well stablished (like Automapper) is AWESOME in performance for traditional hosting, but has a very steep price for the initial load and the first map.

## How do I check the times myself?

### For windows
### For linux (Via docker)
