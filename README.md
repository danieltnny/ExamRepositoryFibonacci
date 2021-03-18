# ExamRepositoryFibonacci

---- RUN STEPS ----

1. Install .NetCore 3.1 SDK https://dotnet.microsoft.com/download/dotnet/3.1

2. You can run the project using the following command over the FivonacciAPI folder:

    - dotnetrun

3. To reach the API you can use postman to reach the following endpoints

    - GET: http://localhost:5000/fibonacci/v1/{index}
    - GET: http://localhost:5000/fibonacci/v2/{index}

Where index represents the index of the desired fibonacci element.

NOTE:

    - The result will be a JSON formatted object
    - Any non positive value will return a BadRequest response
    - This is a test demo, high index values can generate errors reaching the int memory limits.


---- LOGIC ----


Steps and logic of my first approach (not enhaced version):

- We can throw an error to discard any index that is less than 0 since this is not a valid value.
- We threat the 0 and 1 as exceptional cases, since 0 + 0 never will be 1.
- We set up our initial status with lastFibonacci as 0 and newFibonacci as 1.
- We save on an auxiliar variable the newFibonacci, because this will be converted to the last one.
- We sum the new and last Fibonacci variables to generate the new fibonacci number, then replace the last one for the axuliar variable.
- We repeat this process until we get the desired fibonacci index and return the last new Fibonacci variable.

Steps and logic of second version:

- I implemented recursivity to solve the problem
- The result is the sum of executing the same function on the index of the previous 2 numbers
- Taking appart of the same approach that the index 0 and 1 are exceptional cases the consecutive indexes can be calculated.


