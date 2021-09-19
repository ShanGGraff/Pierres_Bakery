# Pierre's Bakery

#### Pierre's Bakery is a basic console application using .NET and C#. When the application is run, the user is prompted with a message stating how much Bread or Pastry they'd like. The application then returns the total cost of the order.

#### **By Shane Graff**

#### Table of Contents

1. [Technologies Used](#technologies)
2. [Description](#description)
3. [Setup/Installation Requirements](#setup)
4. [Specifications](#specs)
5. [Known Bugs](#bugs)
6. [License](#license)
7. [Contact Information](#contact)

## Technologies Used <a id="technologies"></a>

* C#
* .NET

## Description <a id="description"></a>

Pierre's Bakery is a basic console base app written in C# and utilizing .NET unit tests. It utilizes three classes: the Bread class that takes in the total number of loaves ordered and returns the total cost of bread, the Pastry class that takes in the total number of pastries ordered and returns the total cost of the pastries, and the BreadPastryTotalCost class that takes in the total cost from the Bread and Pastry class and returns the total cost of the order.

## Setup/Installation Requirements <a id="setup"></a>

1. If you don't already have C# and .NET installed on your computer, you can get the Software Develment Kit or SDK for Mac here: https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.100-macos-x64-installer and for Windows here: https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.102-windows-x64-installer. Follow the instructions given on that page.
2. Open the terminal on your local machine and navigate to where you want to clone the project
3. Run the following command: __git clone https://github.com/ShanGGraff/Pierres_Bakery__
4. Navigate to Pierres/
5. Run __dotnet build__ on the command line.
6. If everything builds correctly, run __dotnet run__ on the command line.


## Specifications <a id="specs"></a>

| Behavior | Input | Output |
|:---:|:---:|:---:|
| The program should handle user input for the number of breads ordered | When it receives a 0, 1, 2, or 3 | It should return the total cost of the bread|
| The program should handle user input for the number of pastries ordered | When it receives a 0, 1, 3, 4, 5, 6 | It should return the total cost of the pastries |
| The program should handle the output from both the Bread and Pastry class | When the BreadPastryTotalCost class receives Bread.totalCostOfBreads() and Pastry.totalCostOfPastries()| It should return the total cost of the order |

## Known Bugs <a id="bugs"></a>
* Currently can only order 0-3 loaves of bread and 0, 1, 3, 4, 5, or 6 pastries. There is no error handling if the user doesn't follow the instructions from the prompt.

## License
* [MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2021 Creators 

## Contact Information <a id="contact"></a>

* Shane Graff <copellius@gmail.com>
* Github page: https://github.com/ShanGGraff
* LinkedIn: https://www.linkedin.com/in/shanegraff/